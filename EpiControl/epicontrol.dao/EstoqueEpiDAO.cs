using EpiControl.epicontrol.conexao;
using EpiControl.epicontrol.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.dao
{
	public class EstoqueEpiDAO
	{
		private MySqlConnection conexao;

		public EstoqueEpiDAO()
		{
			this.conexao = new ConnectionFactory().getconnetion();
		}

		public void cadastrarEstoqueEpi(EstoqueEpi estoqueEpi)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sql = @"INSERT INTO tb_estoque_epi (quantidade, localizacao, estoque_minimo, fk_epi) VALUES (@quantidade, @localizacao, @estoque_minimo, @fk_epi)";

				MySqlCommand cmd = new MySqlCommand(sql, conexao, transaction);

				cmd.Parameters.AddWithValue("@quantidade", estoqueEpi.quantidade);
				cmd.Parameters.AddWithValue("@localizacao", estoqueEpi.localizacao);
				cmd.Parameters.AddWithValue("@estoque_minimo", estoqueEpi.estoqueMinimo);
				cmd.Parameters.AddWithValue("@fk_epi", estoqueEpi.epiId);

				cmd.ExecuteNonQuery();

				transaction.Commit();
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				MessageBox.Show("Erro ao cadastrar estoque de EPI: " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}
		}

		public DataTable listarEstoqueEpi()
		{
			try
			{
				DataTable tabelaEstoque = new DataTable();

				string sql = @"SELECT ee.id_estoque, e.nome, ee.quantidade, ee.localizacao, ee.estoque_minimo, e.id_epi AS nome_epi FROM tb_estoque_epi ee INNER JOIN tb_epi e ON ee.fk_epi = e.id_epi
                       ORDER BY e.nome;";

				MySqlCommand cmd = new MySqlCommand(sql, conexao);

				conexao.Open();

				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				da.Fill(tabelaEstoque);

				return tabelaEstoque;
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao listar estoque de EPIs: " + ex.Message);
			}
			finally
			{
				if (conexao.State == ConnectionState.Open)
					conexao.Close();
			}
		}

		public List<Epi> listarNomesEpi()
		{
			List<Epi> lista = new List<Epi>();

            string sql = @"SELECT id_epi, nome FROM tb_epi WHERE id_epi NOT IN (SELECT fk_epi FROM tb_estoque_epi) ORDER BY nome";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);

			try
			{
				conexao.Open();
				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					lista.Add(new Epi
					{
						id = reader.GetInt32("id_epi"),
						nome = reader.GetString("nome")
					});
				}

				return lista;
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao listar nomes dos EPIs: " + ex.Message);
			}
			finally
			{
				if (conexao.State == ConnectionState.Open)
					conexao.Close();
			}
		}

		public DataTable buscarEstoqueEpiId(int idEstoque)
		{
			try
			{
				DataTable tabelaEstoque = new DataTable();

				string sql = @"SELECT ee.id_estoque, ee.quantidade, ee.localizacao, ee.estoque_minimo, ee.fk_epi, e.id_epi, e.nome AS nome_epi FROM tb_estoque_epi ee INNER JOIN tb_epi e ON ee.fk_epi = e.id_epi WHERE ee.id_estoque = @id_estoque";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);

				executacmd.Parameters.AddWithValue("@id_estoque", idEstoque);   // ← Corrigido aqui

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelaEstoque);

				return tabelaEstoque;
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao buscar estoque de EPI: " + ex.Message);
			}
			finally
			{
				if (conexao.State == ConnectionState.Open)
					conexao.Close();
			}
		}

		public void excluirEstoqueEpiId(int idEstoque)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sql = @"DELETE FROM tb_estoque_epi WHERE id_estoque = @id";

				MySqlCommand cmd = new MySqlCommand(sql, conexao, transaction);
				cmd.Parameters.AddWithValue("@id", idEstoque);

				cmd.ExecuteNonQuery();

				transaction.Commit();
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				throw new Exception("Erro ao excluir registro do estoque de EPI: " + ex.Message);
			}
			finally
			{
				conexao.Close();
			}
		}

		public void editarEstoqueEpi(EstoqueEpi estoqueEpi)
		{
			conexao.Open();
			MySqlTransaction transaction = conexao.BeginTransaction();

			try
			{
				string sql = @"UPDATE tb_estoque_epi SET quantidade = @quantidade, localizacao = @localizacao, estoque_minimo = @estoque_minimo, fk_epi = @fk_epi WHERE id_estoque = @id_estoque";	

				MySqlCommand cmd = new MySqlCommand(sql, conexao, transaction);

				cmd.Parameters.AddWithValue("@quantidade", estoqueEpi.quantidade);
				cmd.Parameters.AddWithValue("@localizacao", estoqueEpi.localizacao);
				cmd.Parameters.AddWithValue("@estoque_minimo", estoqueEpi.estoqueMinimo);
				cmd.Parameters.AddWithValue("@fk_epi", estoqueEpi.epiId);
				cmd.Parameters.AddWithValue("@id_estoque", estoqueEpi.id);

				cmd.ExecuteNonQuery();

				transaction.Commit();
			}
			catch
			{
				transaction.Rollback();
				throw;
			}
			finally
			{
				conexao.Close();
			}
		}

		public DataTable buscarEstoque(string termoBusca)
		{
			try
			{
				DataTable tabelaEstoque = new DataTable();

				string sql = "SELECT " + "  es.id_estoque, " + "  es.quantidade, " + "  es.localizacao, " + "  es.estoque_minimo, " + "  es.fk_epi AS id_epi, " + "  epi.nome AS epi, " + "  epi.codigo_interno, " + "  epi.ca " + "FROM tb_estoque_epi es " + "LEFT JOIN tb_epi epi ON epi.id_epi = es.fk_epi " + "WHERE " + "      epi.nome LIKE @termo " + "   OR epi.codigo_interno LIKE @termo " + "   OR epi.ca LIKE @termo " + "   OR es.localizacao LIKE @termo " + "   OR CAST(es.id_estoque AS CHAR) LIKE @termo " + "   OR CAST(es.quantidade AS CHAR) LIKE @termo " + "   OR CAST(es.estoque_minimo AS CHAR) LIKE @termo " + "   OR CAST(es.fk_epi AS CHAR) LIKE @termo";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@termo", "%" + termoBusca + "%");

				conexao.Open();

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelaEstoque);

				return tabelaEstoque;
			}
			catch
			{
				return null;
			}
			finally
			{
				if (conexao.State == ConnectionState.Open)
					conexao.Close();
			}
		}

        public bool epiJaCadastrado(int epiId)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM tb_estoque_epi WHERE fk_epi = @fk_epi";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@fk_epi", epiId);

                conexao.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar EPI: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        public List<Epi> listarNomesEpiParaEdicao(int epiIdAtual)
        {
            List<Epi> lista = new List<Epi>();

            string sql = @"SELECT id_epi, nome FROM tb_epi WHERE id_epi NOT IN (SELECT fk_epi FROM tb_estoque_epi) OR id_epi = @epiIdAtual ORDER BY nome";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@epiIdAtual", epiIdAtual);

            try
            {
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Epi
                    {
                        id = reader.GetInt32("id_epi"),
                        nome = reader.GetString("nome")
                    });
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar nomes dos EPIs: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        public List<Epi> listarNomesEpiComEstoque()
        {
            List<Epi> lista = new List<Epi>();

            string sql = @"SELECT ee.id_estoque AS id, e.nome FROM tb_epi e INNER JOIN tb_estoque_epi ee ON ee.fk_epi = e.id_epi ORDER BY e.nome";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Epi
                    {
                        id = reader.GetInt32("id"),
                        nome = reader.GetString("nome")
                    });
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar EPIs com estoque: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        public DataTable listarEpisMaisUtilizadosComPreco()
        {
            try
            {
                DataTable tabela = new DataTable();

                string sql = @" SELECT e.id_epi, e.nome, e.valor_unitario, ( IFNULL(( SELECT SUM(emp.quantidade) FROM tb_emprestimo emp WHERE emp.fk_epi = e.id_epi ), 0) + IFNULL(( SELECT SUM(m.quantidade) FROM tb_movimentacao_estoque m INNER JOIN tb_estoque_epi ee ON ee.id_estoque = m.fk_estoque WHERE ee.fk_epi = e.id_epi AND m.tipo_movimentacao IN ('Saida Emprestimo', 'Saida Descarte') ), 0) ) AS total_saidas FROM tb_epi e WHERE e.valor_unitario > 0 HAVING total_saidas > 0 ORDER BY total_saidas DESC LIMIT 10";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabela);

                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar EPIs mais utilizados: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        public DataTable listarEpisAbaixoDoMinimo()
        {
            try
            {
                DataTable tabela = new DataTable();

                string sql = @" SELECT e.nome, ee.quantidade, ee.estoque_minimo, ee.localizacao FROM tb_estoque_epi ee INNER JOIN tb_epi e ON e.id_epi = ee.fk_epi WHERE ee.quantidade <= ee.estoque_minimo ORDER BY ee.quantidade ASC";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                conexao.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabela);

                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar estoque mínimo: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }
    }
}

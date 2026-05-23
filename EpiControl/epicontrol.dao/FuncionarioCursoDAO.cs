using EpiControl.epicontrol.conexao;
using EpiControl.epicontrol.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;   

namespace EpiControl.epicontrol.dao
{
    public class FuncionarioCursoDAO
    {
        private MySqlConnection conexao;

        public FuncionarioCursoDAO()
        {
            this.conexao = new ConnectionFactory().getconnetion();
        }

        public void cadastrarFuncionarioCurso(FuncionarioCurso funcionarioCurso)
        {
            conexao.Open();
            MySqlTransaction transaction = conexao.BeginTransaction();
            try
            {
                string sql = @"INSERT INTO tb_funcionario_curso (data_inicio, data_conclusao, fk_funcionario, fk_curso) VALUES (@data_inicio, @data_conclusao, @fk_funcionario, @fk_curso)";

                MySqlCommand cmd = new MySqlCommand(sql, conexao, transaction);

                cmd.Parameters.AddWithValue("@data_inicio", funcionarioCurso.inicio);
                cmd.Parameters.AddWithValue("@data_conclusao", funcionarioCurso.conclusao);
                cmd.Parameters.AddWithValue("@fk_funcionario", funcionarioCurso.funcionarioId);
                cmd.Parameters.AddWithValue("@fk_curso", funcionarioCurso.cursoId);

                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao cadastrar funcionário curso: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void excluirFuncionarioCurso(int idFuncionarioCurso)
        {
            conexao.Open();
            MySqlTransaction transaction = conexao.BeginTransaction();
            try
            {
                string sql = @"DELETE FROM tb_funcionario_curso WHERE id_funcionario_curso = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao, transaction);
                cmd.Parameters.AddWithValue("@id", idFuncionarioCurso);
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao excluir funcionário curso: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable listarFuncionarioCursos()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = @" SELECT fc.id_funcionario_curso, fc.data_inicio, fc.data_conclusao, fc.fk_funcionario, fc.fk_curso, f.nome AS nome_funcionario, c.nome AS nome_curso FROM tb_funcionario_curso fc INNER JOIN tb_funcionario f ON f.id_funcionario = fc.fk_funcionario INNER JOIN tb_curso c ON c.id_curso = fc.fk_curso WHERE f.status = 'Ativo'";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar funcionário curso: " + ex.Message);
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable buscarFuncionarioCursoPorId(int idFuncionarioCurso)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = @"SELECT id_funcionario_curso, data_inicio, data_conclusao, fk_funcionario, fk_curso FROM tb_funcionario_curso WHERE id_funcionario_curso = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", idFuncionarioCurso);
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar funcionário curso: " + ex.Message);
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void editarFuncionarioCurso(FuncionarioCurso funcionarioCurso)
        {
            conexao.Open();
            MySqlTransaction transaction = conexao.BeginTransaction();
            try
            {
				string sql = @" UPDATE tb_funcionario_curso SET data_inicio    = @data_inicio, data_conclusao = @data_conclusao, fk_funcionario = @fk_funcionario, fk_curso       = @fk_curso WHERE id_funcionario_curso = @id";

				MySqlCommand cmd = new MySqlCommand(sql, conexao, transaction);

				cmd.Parameters.AddWithValue("@id", funcionarioCurso.id);
				cmd.Parameters.AddWithValue("@data_inicio", funcionarioCurso.inicio);
				cmd.Parameters.AddWithValue("@data_conclusao", funcionarioCurso.conclusao);
				cmd.Parameters.AddWithValue("@fk_funcionario", funcionarioCurso.funcionarioId);
				cmd.Parameters.AddWithValue("@fk_curso", funcionarioCurso.cursoId);


				cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao editar funcionário curso: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
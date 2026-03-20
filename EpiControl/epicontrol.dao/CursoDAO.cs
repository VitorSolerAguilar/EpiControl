using EpiControl.epicontrol.conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EpiControl.epicontrol.dao
{
   
    public class Curso
    {
        public int IdCurso { get; set; }
        public string Nome { get; set; }
        public string CargaHoraria { get; set; }
        public string Descricao { get; set; }
        public int ValidadeMeses { get; set; }
        public string TbCursocol { get; set; } 
    }

    
    public class CursoDAO
    {
        private MySqlConnection conexao;

        public CursoDAO()
        {
            this.conexao = new ConnectionFactory().getconnetion();
        }

        public void cadastrarCurso(Curso curso)
        {
            conexao.Open();
            MySqlTransaction transaction = conexao.BeginTransaction();
            try
            {
                string sqlCurso = @"INSERT INTO tb_curso(nome, carga_horaria, descricao, validade_meses, tb_cursocol) 
                                    VALUES (@nome, @carga_horaria, @descricao, @validade_meses, @tb_cursocol)";

                MySqlCommand cmdCurso = new MySqlCommand(sqlCurso, conexao, transaction);
                cmdCurso.Parameters.AddWithValue("@nome", curso.Nome);
                cmdCurso.Parameters.AddWithValue("@carga_horaria", curso.CargaHoraria);
                cmdCurso.Parameters.AddWithValue("@descricao", curso.Descricao);
                cmdCurso.Parameters.AddWithValue("@validade_meses", curso.ValidadeMeses);
                cmdCurso.Parameters.AddWithValue("@tb_cursocol", curso.TbCursocol);

                cmdCurso.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Erro ao cadastrar curso: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void excluirCurso(int idCurso)
        {
            conexao.Open();
            MySqlTransaction transaction = conexao.BeginTransaction();

            try
            {
                string sqlCurso = @"DELETE FROM tb_curso WHERE id_curso = @id";

                MySqlCommand cmdCurso = new MySqlCommand(sqlCurso, conexao, transaction);
                cmdCurso.Parameters.AddWithValue("@id", idCurso);

                cmdCurso.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Erro ao excluir curso: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable listarCursos()
        {
            try
            {
                DataTable tabelaCurso = new DataTable();

                string sql = @"SELECT * FROM tb_curso";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                conexao.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabelaCurso);

                return tabelaCurso;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar cursos: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        public DataTable buscarCursoPorId(int idCurso)
        {
            try
            {
                DataTable tabelaCurso = new DataTable();

                string sql = @"SELECT id_curso, nome, carga_horaria, descricao, validade_meses, tb_cursocol FROM tb_curso WHERE id_curso = @id_curso";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id_curso", idCurso);

                conexao.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCurso);

                return tabelaCurso;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar curso: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        public void editarCurso(Curso curso)
        {
            conexao.Open();
            MySqlTransaction transaction = conexao.BeginTransaction();

            try
            {
                string sql = @"UPDATE tb_curso SET nome = @nome, carga_horaria = @carga_horaria, descricao = @descricao, validade_meses = @validade_meses, tb_cursocol = @tb_cursocol WHERE id_curso = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conexao, transaction);

                cmd.Parameters.AddWithValue("@nome", curso.Nome);
                cmd.Parameters.AddWithValue("@carga_horaria", curso.CargaHoraria);
                cmd.Parameters.AddWithValue("@descricao", curso.Descricao);
                cmd.Parameters.AddWithValue("@validade_meses", curso.ValidadeMeses);
                cmd.Parameters.AddWithValue("@tb_cursocol", curso.TbCursocol);
                cmd.Parameters.AddWithValue("@id", curso.IdCurso);

                cmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Erro ao editar curso: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        public DataTable buscarCursoPorNome(string nomeCurso)
        {
            try
            {
                DataTable tabelaCurso = new DataTable();

                string sql = @"SELECT id_curso, nome, carga_horaria, descricao, validade_meses, tb_cursocol FROM tb_curso WHERE nome LIKE @nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", "%" + nomeCurso + "%");

                conexao.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCurso);

                return tabelaCurso;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar curso por nome: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }
    }
}


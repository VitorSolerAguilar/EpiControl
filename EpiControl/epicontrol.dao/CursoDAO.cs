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

namespace EpiControl.epicontrol.dao
{   
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
                string sqlCurso = @"INSERT INTO tb_curso(nome, carga_horaria, descricao, validade_meses) 
                                    VALUES (@nome, @carga_horaria, @descricao, @validade_meses)";

                MySqlCommand cmdCurso = new MySqlCommand(sqlCurso, conexao, transaction);
                cmdCurso.Parameters.AddWithValue("@nome", curso.nome);
                cmdCurso.Parameters.AddWithValue("@carga_horaria", curso.cargaHoraria);
                cmdCurso.Parameters.AddWithValue("@descricao", curso.descricao);
                cmdCurso.Parameters.AddWithValue("@validade_meses", curso.validadeMeses);

                cmdCurso.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao cadastrar curso: " + ex.Message);
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
                MessageBox.Show("Erro ao excluir curso: " + ex.Message);
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
                MessageBox.Show("Erro ao listar cursos: " + ex.Message);
                return null;
            }
            finally
            {
                    conexao.Close();
            }
        }

        public DataTable buscarCursoPorId(int idCurso)
        {
            try
            {
                DataTable tabelaCurso = new DataTable();

                string sql = @"SELECT id_curso, nome, carga_horaria, descricao, validade_meses FROM tb_curso WHERE id_curso = @id_curso";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id_curso", idCurso);

                conexao.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCurso);

                return tabelaCurso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar curso: " + ex.Message);
                return null;
            }
            finally
            {
                    conexao.Close();
            }
        }

        public void editarCurso(Curso curso)
        {
            conexao.Open();
            MySqlTransaction transaction = conexao.BeginTransaction();

            try
            {
                string sql = @"UPDATE tb_curso SET nome = @nome, carga_horaria = @carga_horaria, descricao = @descricao, validade_meses = @validade_meses WHERE id_curso = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conexao, transaction);

                cmd.Parameters.AddWithValue("@nome", curso.nome);
                cmd.Parameters.AddWithValue("@carga_horaria", curso.cargaHoraria);
                cmd.Parameters.AddWithValue("@descricao", curso.descricao);
                cmd.Parameters.AddWithValue("@validade_meses", curso.validadeMeses);
                cmd.Parameters.AddWithValue("@id", curso.id);

                cmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao editar curso: " + ex.Message);
            }
            finally
            {
                    conexao.Close();
            }
        }

        public DataTable buscarCursoPorNome(string nomeCurso)
        {
            try
            {
                DataTable tabelaCurso = new DataTable();

                string sql = @"SELECT id_curso, nome, carga_horaria, descricao, validade_meses FROM tb_curso WHERE nome LIKE @nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", "%" + nomeCurso + "%");

                conexao.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCurso);

                return tabelaCurso;
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Erro ao buscar curso por nome: " + ex.Message);
                return null;
            }
            finally
            {
                    conexao.Close();
            }
        }
    }
}


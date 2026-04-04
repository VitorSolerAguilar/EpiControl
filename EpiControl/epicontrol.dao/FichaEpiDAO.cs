using EpiControl.epicontrol.conexao;
using EpiControl.epicontrol.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.dao
{
	public class FichaEpiDAO
	{
		private MySqlConnection conexao;

		public FichaEpiDAO()
		{
			this.conexao = new ConnectionFactory().getconnetion();
		}

		public List<FichaEpiDTO> BuscarFichaPorFuncionario(int idFuncionario)
		{
			List<FichaEpiDTO> lista = new List<FichaEpiDTO>();

			string sql = @"SELECT f.nome, e.nome, e.ca, emp.quantidade, emp.data_entrega
                   FROM tb_emprestimo emp
                   JOIN tb_funcionario f ON emp.fk_funcionario = f.id_funcionario
                   JOIN tb_epi e ON emp.fk_epi = e.id_epi
                   WHERE f.id_funcionario = @id";

			MySqlCommand cmd = new MySqlCommand(sql, conexao);
			cmd.Parameters.AddWithValue("@id", idFuncionario);

			MySqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				lista.Add(new FichaEpiDTO
				{
					Funcionario = dr.GetString(0),
					Epi = dr.GetString(1),
					CA = dr.GetString(2),
					Quantidade = dr.GetInt32(3),
					Data = dr.GetDateTime(4)
				});
			}

			dr.Close();
			return lista;
		}
	}
}

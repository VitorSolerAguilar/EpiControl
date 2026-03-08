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
	public class EmprestimoDAO
	{
		private MySqlConnection conexao;

		public EmprestimoDAO(MySqlConnection conexao)
		{
			this.conexao = new ConnectionFactory().getconnetion();
		}


	}
}

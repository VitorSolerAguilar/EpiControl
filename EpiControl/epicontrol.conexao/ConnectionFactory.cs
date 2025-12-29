using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.conexao
{
	public class ConnectionFactory
	{
		public MySqlConnection getconnetion()
		{
			string connStr = Program.Configuration.GetConnectionString("bdepicontrol");
			if (string.IsNullOrWhiteSpace(connStr))
				throw new Exception("Connection string 'bdepicontrol' não encontrada.");

			return new MySqlConnection(connStr);
		}
	}
}

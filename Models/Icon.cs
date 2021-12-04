using System.Data;
using System.Data.SqlClient;

namespace Mint.API.Models
{
    public class Icon
	{

		public int Id { get; set; }
		public byte[] Data { get; set; } = new byte[]{};

		public bool Read(SqlDataReader pReader)
		{
			if (pReader == null || !pReader.Read()) return false;

			Id		= pReader.GetFieldValue<int>("ICON_id");
			Data	= pReader.GetFieldValue<byte[]>("ICON_data");

			return true;
		}

	}
}
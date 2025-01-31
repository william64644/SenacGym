using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySmile;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Senac_Gym
{
    internal class Atividade
    {
        public int id { get; set; }
        public int idMusculo { get; set; }
        public int idExercicio { get; set; }
        public int idAluno { get; set; }
        public string comentario { get; set; }
        public int serie { get; set; }
        public int repeticao { get; set; }
        public string treino { get; set; }

        public Atividade()
        {
            id = 0;
            idMusculo = 0;
            idExercicio = 0;
            idAluno = 0;
            comentario = string.Empty;
            serie = 0;
            repeticao = 0;
            treino = string.Empty;
        }

        // Objetos para acesso ao banco
        AcessoBD acesso = new AcessoBD();
        DataTable dt = new DataTable();
        List<SqlParameter> lista = new List<SqlParameter>();
        string sql = string.Empty;

        public DataTable Consultar()
        {
            try
            {
                lista.Clear();
                sql = "SELECT id, idMusculo, idExercicio, idAluno, comentario, serie, repeticao, treino \n";
                sql += "FROM tblAtividade \n";

                if (id != 0)
                {
                    sql += "WHERE id = @id \n";
                    lista.Add(new SqlParameter("@id", id));
                }

                sql += "ORDER BY treino";
                dt = acesso.ConsultarSQL(sql, lista);

                // Preenche propriedades se encontrar registro único
                if (dt.Rows.Count > 0 && id != 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    idMusculo = Convert.ToInt32(dt.Rows[0]["idMusculo"]);
                    idExercicio = Convert.ToInt32(dt.Rows[0]["idExercicio"]);
                    idAluno = Convert.ToInt32(dt.Rows[0]["idAluno"]);
                    comentario = dt.Rows[0]["telefone"].ToString();
                    serie = Convert.ToInt32(dt.Rows[0]["serie"]);
                    repeticao = Convert.ToInt32(dt.Rows[0]["repeticao"]);
                    treino = dt.Rows[0]["treino"].ToString();
                    //nome = dt.Rows[0]["nome"].ToString();
                    //celular = dt.Rows[0]["telefone"].ToString();
                    //email = dt.Rows[0]["email"].ToString();
                    //dataNascimento = Convert.ToDateTime(dt.Rows[0]["dataNascimento"]);
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Gravar()
        {
            try
            {
                lista.Clear();
                if (id == 0)
                {
                    sql = "INSERT INTO tblAluno \n";
                    sql += "(nome, telefone, email, dataNascimento) \n";
                    sql += "VALUES \n";
                    sql += "(@nome, @telefone, @email, @dataNascimento)";
                }
                else
                {
                    sql = "UPDATE tblAluno \n";
                    sql += "SET \n";
                    sql += "nome = @nome, \n";
                    sql += "telefone = @telefone, \n";
                    sql += "email = @email, \n";
                    sql += "dataNascimento = @dataNascimento \n";
                    sql += "WHERE id = @id";
                    lista.Add(new SqlParameter("@id", id));
                }

                // Parâmetros comuns
                //lista.Add(new SqlParameter("@nome", nome));
                //lista.Add(new SqlParameter("@telefone", celular));
                //lista.Add(new SqlParameter("@email", email));
                //lista.Add(new SqlParameter("@dataNascimento", dataNascimento));

                acesso.ExecutarSQL(sql, lista);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    
}

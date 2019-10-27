using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUSCS_RJI5S.Class
{
    class City
    {
        Database db;

        #region ATRIBUTOS
        private int id_Cidade;
        private string SIGLA;
        private string nome;
        private int posicao_X;
        private int posicao_Y;
        #endregion


        public City(string SIGLA, string nome, int posicao_X = 50, int posicao_Y = 50)
        {
            this.SetSIGLA(SIGLA);
            this.SetNome(nome);
            this.SetPosicao_X(posicao_X);
            this.SetPosicao_Y(posicao_Y);
        }

        public City() { }

        #region METODOS

        #region GET/SET
        public int GetId_Cidade()
        {
            return id_Cidade;
        }
        public string GetSIGLA()
        {
            return SIGLA;
        }
        public string Getnome()
        {
            return nome;
        }
        public int GetPosicao_X()
        {
            return posicao_X;
        }
        public int GetPosicao_Y()
        {
            return posicao_Y;
        }

        public void SetSIGLA(string value)
        {
            if (value.Length > 0)
            {
                SIGLA = value.Trim().Substring(0, 3).ToUpper();
            }
            else
            {
                SIGLA = "???";
            }
        }
        public void SetNome(string value)
        {
            nome = value.Trim().ToUpper();
        }
        public void SetPosicao_X(int value)
        {
            posicao_X = value;
        }
        public void SetPosicao_Y(int value)
        {
            posicao_Y = value;
        }
        #endregion

        public long includeDB()
        {
            try
            {
                db = new Database();
                db.Conectar();
                string connStr = String.Format("INSERT INTO cidade values (null, '{0}', '{1}', '{2}', '{3}')", this.SIGLA, this.nome, this.posicao_X, this.posicao_Y);
                long lastId = db.ExecutarComandoSQL(connStr);
                if (lastId > 0)
                {
                    return lastId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao incluir!" + e.Message);
            }
            finally
            {
                db = null;
            }
        }

        public long DeleteDB()
        {
            try
            {
                db = new Database();
                db.Conectar();
                string connStr = String.Format("DELETE FROM cidade WHERE sigla='{0}'", this.SIGLA);
                long lastId = db.ExecutarComandoSQL(connStr, true);
                if (lastId > 0)
                {
                    return lastId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir! " + e.Message);
            }
            finally
            {
                db = null;
            }
        }

        public DataTable ListCitysDB()
        {
            try
            {
                db = new Database();
                db.Conectar();
                return db.RetDataTable("SELECT * FROM cidade");
            }
            catch (Exception)
            {
                throw new Exception("Erro ao buscar lista de tarefas!");
            }
            finally
            {
                db = null;
            }
        }
        #endregion

    }
}

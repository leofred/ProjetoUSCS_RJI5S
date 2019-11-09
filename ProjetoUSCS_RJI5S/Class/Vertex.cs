using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUSCS_RJI5S.Class
{
    class Vertex
    {
        Database db;

        #region ATRIBUTOS
        private City p1;
        private City p2;
        private int metricA;
        private int metricB;
        private int metricC;
        #endregion

        #region CONSTRUTORES

        public Vertex(City p1, City p2, int metricB = 1, int metricC = 1)
        {
            this.SetP1(p1);
            this.SetP2(p2);
            this.SetMetricA(1);
            this.SetMetricB(metricB);
            this.SetMetricC(metricC);
        }
        public Vertex() { }
        #endregion

        #region METODOS

        #region GET/SET
        public City GetP1()
        {
            return p1;
        }
        public City GetP2()
        {
            return p2;
        }
        public int GetMetricA()
        {
            return metricA;
        }
        public int GetMetricB()
        {
            return metricB;
        }
        public int GetMetricC()
        {
            return metricC;
        }

        public void SetP1(City value)
        {
            p1 = value;
        }
        public void SetP2(City value)
        {
            p2 = value;
        }
        private void SetMetricA(int value)
        {
            metricA = value;
        }
        public void SetMetricB(int value)
        {
            metricB = value;
        }
        public void SetMetricC(int value)
        {
            metricC = value;
        }
        #endregion

        public bool includeDB()
        {
            try
            {
                db = new Database();
                db.Conectar();
                string connStr = String.Format("INSERT INTO vertices values ('{0}', '{1}', '{2}', '{3}', '{4}')", this.p1, this.p2, this.metricA, this.metricB, this.metricC);
                db.ExecutarComandoSQL(connStr);
                return true;
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

        public bool DeleteDB()
        {
            try
            {
                db = new Database();
                db.Conectar();
                string connStr = String.Format("DELETE FROM vertices WHERE P1_Cidade = '{0}' and P2_Cidade = '{0}'", this.p1, this.p2);
                db.ExecutarComandoSQL(connStr);
                return true;
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
                return db.RetDataTable("SELECT * FROM vertices");
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

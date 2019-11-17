using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUSCS_RJI5S.Class {
    class Vertex {
        Database db;

        #region ATRIBUTOS
        private string P1;
        private string P2;
        private int metricA;
        private int metricB;
        private int metricC;
        #endregion

        #region CONSTRUTORES

        public Vertex ( string p1 , string p2 , int metricA = 1 , int metricB = 1 , int metricC = 1 ) {
            this.SetP1 ( p1 );
            this.SetP2 ( p2 );
            this.SetMetricA ( metricA );
            this.SetMetricB ( metricB );
            this.SetMetricC ( metricC );
        }
        public Vertex () { }
        #endregion

        #region METODOS

        #region GET/SET
        public string GetP1 () {
            return this.P1;
        }
        public string GetP2 () {
            return this.P2;
        }
        public int GetMetric(string metric ) {
            switch ( metric ) {
                case "A":
                    return metricA;
                case "B":
                    return metricB;
                case "C":
                    return metricC;
                default:
                    return 1;
            }
        }
        private int GetMetricA () {
            return metricA;
        }
        private int GetMetricB () {
            return metricB;
        }
        private int GetMetricC () {
            return metricC;
        }

        public void SetP1 ( string value ) {
            this.P1 = value;
        }
        public void SetP2 ( string value ) {
            this.P2 = value;
        }
        private void SetMetricA ( int value ) {
            metricA = value;
        }
        public void SetMetricB ( int value ) {
            metricB = value;
        }
        public void SetMetricC ( int value ) {
            metricC = value;
        }
        #endregion

        public bool IncludeDB () {
            try {
                db = new Database ( );
                db.Conectar ( );
                string connStr = String.Format ( "INSERT INTO vertice values ('{0}', '{1}', '{2}', '{3}', '{4}')" , this.P1 , this.P2 , this.metricA , this.metricB , this.metricC );
                db.ExecutarComandoSQL ( connStr );
                return true;
            } catch ( Exception e ) {
                throw new Exception ( "Erro ao incluir!" + e.Message );
            } finally {
                db = null;
            }
        }

        public bool DeleteDB () {
            try {
                db = new Database ( );
                db.Conectar ( );
                string connStr = String.Format ( "DELETE FROM vertices WHERE P1_Cidade = '{0}' and P2_Cidade = '{0}'" , this.P1 , this.P2 );
                db.ExecutarComandoSQL ( connStr );
                return true;
            } catch ( Exception e ) {
                throw new Exception ( "Erro ao excluir! " + e.Message );
            } finally {
                db = null;
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUSCS_RJI5S.Class {
    class City {
        Database db;

        #region ATRIBUTOS
        private string Sigla;
        private string Nome;
        private int Posicao_X;
        private int Posicao_Y;
        #endregion


        public City ( string Sigla , string Nome , int Posicao_X = 50 , int Posicao_Y = 50 ) {
            this.SetSIGLA ( Sigla );
            this.SetNome ( Nome );
            this.SetPosicao_X ( Posicao_X );
            this.SetPosicao_Y ( Posicao_Y );
        }

        public City () { }

        #region METODOS

        #region GET/SET
        public string GetSIGLA () {
            return this.Sigla;
        }
        public string Getnome () {
            return this.Nome;
        }
        public int GetPosicao_X () {
            return this.Posicao_X;
        }
        public int GetPosicao_Y () {
            return this.Posicao_Y;
        }

        public void SetSIGLA ( string value ) {
            if ( value.Length > 0 ) {
                this.Sigla = value.Trim ( ).Substring ( 0 , 3 ).ToUpper ( );
            } else {
                throw new Exception ( "Erro ao setar a Sigla!" );
            }
        }
        public void SetNome ( string value ) {
            this.Nome = value.Trim ( ).ToUpper ( );
        }
        public void SetPosicao_X ( int value ) {
            Posicao_X = value;
        }
        public void SetPosicao_Y ( int value ) {
            this.Posicao_Y = value;
        }
        #endregion

        public long includeDB () {
            try {
                db = new Database ( );
                db.Conectar ( );
                string connStr = String.Format ( "INSERT INTO cidade values (null, '{0}', '{1}', '{2}', '{3}')" , this.Sigla , this.Nome , this.Posicao_X , this.Posicao_Y );
                long lastId = db.ExecutarComandoSQL ( connStr , true );
                if ( lastId > 0 ) {
                    return lastId;
                } else {
                    return -1;
                }
            } catch ( Exception e ) {
                throw new Exception ( "Erro ao incluir!" + e.Message );
            } finally {
                db = null;
            }
        }

        public long DeleteDB () {
            try {
                db = new Database ( );
                db.Conectar ( );
                string connStr = String.Format ( "DELETE FROM cidade WHERE sigla='{0}'" , this.Sigla );
                long lastId = db.ExecutarComandoSQL ( connStr , true );
                if ( lastId > 0 ) {
                    return lastId;
                } else {
                    return -1;
                }
            } catch ( Exception e ) {
                throw new Exception ( "Erro ao excluir! " + e.Message );
            } finally {
                db = null;
            }
        }


        #endregion

    }
}

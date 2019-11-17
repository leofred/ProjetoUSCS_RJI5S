using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProjetoUSCS_RJI5S.Class {
    class Database {

        private MySqlConnection conn;
        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlCommandBuilder cb;

        public static String server = "127.0.0.1";
        public static String port = "3306";
        public static String user = "root";
        public static String password = "";
        public static String database = "uscsnet";

        public void Conectar () {
            if ( conn != null )
                conn.Close ( );

            string connStr = String.Format ( "Server={0};port={1};user id={2};password={3}; database={4};pooling=false" , server , port , user , password , database );

            try {
                conn = new MySqlConnection ( connStr );
                conn.Open ( );
            } catch ( MySqlException ex ) {
                throw new Exception ( ex.Message );
            }

        }

        public long ExecutarComandoSQL ( string comandoSql , bool ReturnLastInsertedId = false ) {
            MySqlCommand comando = new MySqlCommand ( comandoSql , conn );
            comando.ExecuteNonQuery ( );
            long id = comando.LastInsertedId;
            conn.Close ( );
            if ( ReturnLastInsertedId == true ) {
                return id;
            } else {
                return 0;
            }
        }

        public MySqlDataReader RetDataReader ( string sql ) {
            MySqlCommand comando = new MySqlCommand ( sql , conn );
            MySqlDataReader dr = comando.ExecuteReader ( );
            return dr;
        }

        public List<City> getAllCitys () {
            List<City> city_list = new List<City> ( );

            try {
                this.Conectar ( );
                MySqlCommand comando = new MySqlCommand ( "select * from cidade" , conn );
                MySqlDataReader dr = comando.ExecuteReader ( );

                while ( dr.Read ( ) ) {
                    City node = new City (
                      dr [ "Sigla" ].ToString ( ) ,
                      dr [ "Nome" ].ToString ( ) ,
                      int.Parse ( dr [ "Posicao_X" ].ToString ( ) ) ,
                      int.Parse ( dr [ "Posicao_Y" ].ToString ( ) )
                      );
                    city_list.Add ( node );
                }
                conn.Close ( );
                return city_list;
            } catch ( MySqlException ex ) {

                throw new Exception ( ex.Message );
            } catch ( Exception ex ) {

                throw new Exception ( ex.Message );
            }

        }

        public List<Vertex> getAllVertex () {
            List<Vertex> vertex_list = new List<Vertex> ( );

            try {
                this.Conectar ( );
                MySqlCommand comando = new MySqlCommand ( "select * from vertice" , conn );
                MySqlDataReader dr = comando.ExecuteReader ( );

                while ( dr.Read ( ) ) {
                    Vertex node = new Vertex (
                      dr [ "P1_Sigla" ].ToString ( ) ,
                      dr [ "P2_Sigla" ].ToString ( ) ,
                      int.Parse ( dr [ "Metrica_A" ].ToString ( ) ) ,
                      int.Parse ( dr [ "Metrica_B" ].ToString ( ) ) ,
                      int.Parse ( dr [ "Metrica_C" ].ToString ( ) )
                      );
                    vertex_list.Add ( node );
                }
                conn.Close ( );
                return vertex_list;
            } catch ( MySqlException ex ) {
                throw new Exception ( ex.Message );
            } catch ( Exception ex ) {
                throw new Exception ( ex.Message );
            }

        }
    }
}
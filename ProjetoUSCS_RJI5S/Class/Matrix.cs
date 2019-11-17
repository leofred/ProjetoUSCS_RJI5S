using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUSCS_RJI5S.Class {
    class Matrix {

        public int [ , ] MatrixStruct { get; set; }
        public List<City> CityList { get; set; }
        public List<Vertex> VertexList { get; set; }
        public string Metric { get; set; }

        public Matrix ( List<City> CityList , List<Vertex> VertexList, string Metric ) {
            this.CityList = CityList;
            this.VertexList = VertexList;
            this.Metric = Metric;
        }

        public int [ , ] createMatrix () {
            int cityQtd = CityList.Count ( );
            int vertexQtd = VertexList.Count ( );
            MatrixStruct = new int [ cityQtd , cityQtd ];

            for ( int i = 0 ; i < cityQtd ; i++ ) { //line

                for ( int j = 0 ; j < vertexQtd ; j++ ) { //column

                    if ( CityList [ i ].GetSIGLA() == VertexList [ j ].GetP1() ) { // find index in origin
                        int index = CityList.FindIndex ( city => city.GetSIGLA() == VertexList [ j ].GetP2() );
                        if ( index != -1 ) {
                            MatrixStruct [ i , index ] = VertexList [ j ].GetMetric ( Metric );
                        } 
                    }
                    if ( CityList [ i ].GetSIGLA ( ) == VertexList [ j ].GetP2() ) { // find index in destiny
                        int index = CityList.FindIndex ( city => city.GetSIGLA ( ) == VertexList [ j ].GetP1 ( ) );
                        if ( index != -1 ) {
                            MatrixStruct [ i, index ] = VertexList [ j ].GetMetric ( Metric );
                        }
                    }
                }
            }

            printMatrix ( );
            return MatrixStruct;
        }

        public void printMatrix () {
            int cityQtd = CityList.Count ( );

            bool topLabel = true;
            Console.Write ( "\n\n" );
            Console.Write ( "\t" );
            for ( int i = 0 ; i < cityQtd ; i++ ) {
                for ( int k = 0 ; k < cityQtd ; k++ ) {
                    if ( topLabel ) {
                        Console.Write ( "\t" + CityList [ k ].GetSIGLA() );
                    }
                }
                topLabel = false;
                Console.WriteLine ( );

                Console.Write ( " " + CityList [ i ].GetSIGLA ( ) + "\t" );
                for ( int j = 0 ; j < cityQtd ; j++ ) {
                    Console.Write ( MatrixStruct [ i , j ] + "\t" );
                }
                Console.WriteLine ( );
            }
        }

    }
}

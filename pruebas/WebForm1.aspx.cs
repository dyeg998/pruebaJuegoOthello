using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace pruebas
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
            //AL INICIAR LA PAGINA SE CREA LA TABLA
            pruebaTabla();      
        }

        //ARREGLO CON VALORES PREDETERMINADOS PARA ASOCIARLO CON LOS BOTONES
        int[,] a = new int[8, 8] {
               {0, 0, 0, 0, 0, 0, 0, 0} ,
               {0, 0, 0, 0, 0, 0, 0, 0} ,
               {0, 0, 0, 0, 0, 0, 0, 0} ,
               {0, 0, 0, 1, 2, 0, 0, 0} ,
               {0, 0, 0, 2, 1, 0, 0, 0} ,
               {0, 0, 0, 0, 0, 0, 0, 0} ,
               {0, 0, 0, 0, 0, 0, 0, 0} ,
               {0, 0, 0, 0, 0, 0, 0, 0}
            };


        public void pruebaTabla()
        {
            for (int j = 0; j < 8; j++)
            {
                //CREO UNA FILA POR CADA NUMERO DEL CICLO: FOR
                HtmlTableRow row = new HtmlTableRow();
                for (int i = 0; i < 8; i++)
                {
                    //CREO UN BOTON POR CADA NUMERO DEL CICLO
                    Button btn = new Button();                   
                    btn.ID = j.ToString() + i.ToString();
                    btn.Text = " ";
                    btn.BackColor = Color.Green;

                    //SI UN BOTON ES CLICKEADO QUE SE VAYA AL METODO QUE PINTE EL BOTON
                    btn.Click += new EventHandler(pintardisc);

                    //CREO COLUMNAS PARA INTRODUCIR LOS BOTONES
                    HtmlTableCell cell = new HtmlTableCell();

                    //AGREGO LOS BOTONES A LA CASILLA
                    cell.Controls.Add(btn);

                    //AGREGO LAS CASILLAS A LA TABLA
                    row.Cells.Add(cell);

                    //VERIFICO SI UN VALOR DEL INDICE DEL ARREGLO EQUIVALE A 0, 1 O 2 PARA QUE PINTE SEGUN CORRESPONDA
                    if (a[j, i] == 0)
                    {
                        //SI EL VALOR ES 0 NO HACE NADA
                    }
                    else
                    {
                        if (a[j, i] == 1)
                        {
                            //SI EL VALOR ES 1 QUE SEA BLANCO EL BOTON
                            btn.BackColor = Color.White;
                        }
                        if (a[j, i] == 2)
                        {
                            //SI EL VALOR ES 2 QUE SEA NEGRO EL BOTON
                            btn.BackColor = Color.Black;
                        }
                    }
                }
                //AGREGO TODO A LA TABLA
                Table1.Rows.Add(row);
            }
        }

      


        //METODO DEL BOTON CLICKEADO
        private void pintardisc(object sender, EventArgs e)
        {
            //ME CONSIGUE TODOS LOS ATRIBUTOS DEL BOTON CLIKEADO
            Button btn = (Button)sender;

            //PASO EL VALOR DEL ID DEL BOTON DE STRING A INT
            int boton = Int32.Parse(btn.ID);

            //SEPARO LOS VALORES DEL ID TRANSFORMADO A INT PARA CONSEGUIR EL NUMERO DE FILA Y COLUMNA EN ESPECIFICO
            //X = FILA
            int x = boton / 10;

            //X2 = COLUMNA
            int x2 = boton % 10;
            
            //PARA VERIFICAR EL TURNO LO QUE HICE  FUE CREAR UN HIDDENFIELD CON EL VALOR PREDETERMINADO DE "2" PARA QUE EL PRIMER MOVIMIENTO SEA NEGRO
            //PASO EL VALOR DEL HIDDENFIELD LLAMADO TURNO A INT
            int turn = Int32.Parse(turno.Value);

            /*AQUI VERIFICO QUE EL ID SEPARADO DEL BOTON EQUIVALGA A UN INDICE DEL ARREGLO Y POSTERIORMENTE CUANDO ENCUENTRE EL INDICE, HAGO QUE CAMBIE EL VALOR
            CONFORME AL TURNO CORRESPONDIENTE*/
            a[x, x2] = turn;

            /*SI EL VALOR DEL TURNO ES "1" QUE ME PINTE EL BOTON DE BLANCO
            Y CON EL "ELSE" VERIFICO QUE EL TURNO ES "2" PARA QUE PINTE LA PIEZA DE NEGRO*/

            if (Int32.Parse(turno.Value) == 1)
            {
                turno.Value = "2";
                btn.BackColor = Color.White;
                btn.Enabled = false;
            }     
            else
            {
                turno.Value = "1";
                btn.BackColor = Color.Black;
                btn.Enabled = false;


                               
                
            }

        }

    }
}

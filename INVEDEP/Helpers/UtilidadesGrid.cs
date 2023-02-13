using System.Data;
using System.Reflection;

namespace INVEDEP.Helpers
{
    public static class UtilidadesGrid
    {
        public static void CopiarPortaPaeles(DataGridView dataGrid)
        {
            DataObject ObjetoDatos = dataGrid.GetClipboardContent();
            Clipboard.SetDataObject(ObjetoDatos);

            
        }

        public static DataTable PegarPortaPapeles(PropertyInfo[] lst )
        {
            
            DataTable dt = new DataTable();
            string TextoCopiado = Clipboard.GetText();
            string[] lineas = TextoCopiado.Split('\n');
            int ultima = lineas.Count() - 1;
            



            foreach (var item in lst)
            {
                string NameProperty = item.Name;
                
                

                dt.Columns.Add(NameProperty,item.PropertyType);
                

            }

            foreach (string line in lineas)
            {
                DataRow tabla = dt.NewRow();
                string[] Celdas = line.Split('\t');
                bool saltar = false;
                for (int indice = 0; indice < Celdas.GetLength(0); indice++)
                {
                    if (Celdas[indice] != "\r" && Celdas[indice] != "" && Celdas[indice] != " ")
                        tabla[lst[indice].Name] = Convert.ChangeType(Celdas[indice], lst[indice].PropertyType);

                    
                    //dt.Rows.Add(new object[] { Convert.ChangeType(Celdas[indice], lst[indice].PropertyType)});
                }


                    dt.Rows.Add(tabla);
            }





            //dt.Rows.Add(new object[] {2,2023,"Ernesto","Flores","Perez"});


            return dt;

        }

        private static void CrearFilas(string[] lineas, int ultima, DataTable dt)
        {
            dt.Clear();
            int i;
            for (i = 0; i < ultima; i++)
            {
                dt.Rows.Add(lineas[i]);
            }

        }
    }
}

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

                foreach (var item in lst)
                {
                    string NameProperty = item.Name;



                    dt.Columns.Add(NameProperty, item.PropertyType);


                }

                foreach (string line in lineas)
                {
                    DataRow tabla = dt.NewRow();
                    bool Saltar = false;
                    string[] Celdas = line.Split('\t');

                        for (int indice = 0; indice < Celdas.GetLength(0); indice++)
                        {

                            if (Celdas[indice] != "\r" && Celdas[indice] != "" && Celdas[indice] != " ")

                                tabla[lst[indice].Name] = Convert.ChangeType(Celdas[indice], lst[indice].PropertyType);





                        }




                    dt.Rows.Add(tabla);
                }


                return dt;




        }


    }
}

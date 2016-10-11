using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Windows.Forms;
//using MySql.Data;
using System.Data;
using System.Data.Odbc;
//using ConexionODBC;

namespace FuncionesNavegador
{
    public class ManejoDeControles
    {
        //private  OdbcCommand mySqlComando;
        //private  OdbcDataAdapter mySqlDAdAdaptador;



        //MANEJO DE CONTROLES
        #region Abilitar/Inhabilidat Controles


            public static int FunDesactivarTextbox(TextBox textbox, Boolean valor)
            {
                textbox.Enabled = valor;
                return 0;
            }

            public static int FunDesactivarButton(Button button, bool valor)
            {
                button.Enabled = valor;
                return 0;
            }

            public static int FunDesactivarCheckBox(CheckBox checkbox, bool valor)
            {
                checkbox.Enabled = valor;
                return 0;
            }

            public static int FunDesactivarCheckedListBox(CheckedListBox checkedlistBox, bool valor)
            {
                checkedlistBox.Enabled = valor;
                return 0;
            }

            public static int FunDesactivarComboBox(ComboBox combobox, bool valor)
            {
                combobox.Enabled = valor;
                return 0;
            }

            public static int FunDesactivarDateTimePicker(DateTimePicker datetimepicker, bool valor)
            {
                datetimepicker.Enabled = valor;
                return 0;
            }

            public static int FunDesactivarListBox(ListBox listbox, bool valor)
            {
                listbox.Enabled = valor;
                return 0;
            }

            public static int FunDesactivarListView(ListView listview, bool valor)
            {
                listview.Enabled = valor;
                return 0;
            }

            public static int FunDesactivarNumericUpDown(NumericUpDown numericupdown, bool valor)
            {
                numericupdown.Enabled = valor;
                return 0;
            }

            public static int FunDesactivarPictureBox(PictureBox picturebox, bool valor)
            {
                picturebox.Enabled = valor;
                return 0;
            }

            public static int FunDesactivarRadioButton(RadioButton radiobutton, bool valor)
            {
                radiobutton.Enabled = valor;
                return 0;
            }

            public static int FunDesactivarDataGridView(DataGridView datagridview, bool valor)
            {
                datagridview.Enabled = valor;
                return 0;
            }

            #endregion
        }
}

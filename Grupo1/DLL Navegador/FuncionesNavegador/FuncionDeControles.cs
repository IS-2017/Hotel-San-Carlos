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
using FuncionesNavegador;

namespace FuncionesNavegador
{
     public class FuncionDeControles
    {
        //private static OdbcCommand mySqlComando;
        //private static OdbcDataAdapter mySqlDAdAdaptador;



        //MANEJO DE CONTROLES
        #region Abilitar/Inhabilidat Controles

        public void DesactivarTextbox(TextBox txtboxnuevo, Boolean estado)
        {
            ManejoDeControles.FunDesactivarTextbox(txtboxnuevo, estado);
        }

        public void DesactivarButton(Button buttonnueo, Boolean estado)
        {
            ManejoDeControles.FunDesactivarButton(buttonnueo, estado);
        }

        public void DesactivarCheckBox(CheckBox checkbox, Boolean estado)
        {
            ManejoDeControles.FunDesactivarCheckBox(checkbox, estado);
        }

        public void DesactivarCheckedListBox(CheckedListBox checkedlistbox, Boolean estado)
        {
            ManejoDeControles.FunDesactivarCheckedListBox(checkedlistbox, estado);
        }

        public void DesactivarComboBox(ComboBox combobox, Boolean estado)
        {
            ManejoDeControles.FunDesactivarComboBox(combobox, estado);
        }

        public void DesactivarDateTimePicker(DateTimePicker datetimepicker, Boolean estado)
        {
            ManejoDeControles.FunDesactivarDateTimePicker(datetimepicker, estado);
        }

        public void DesactivarListBox(ListBox listbox, Boolean estado)
        {
            ManejoDeControles.FunDesactivarListBox(listbox, estado);
        }

        public void DesactivarListView(ListView listview, Boolean estado)
        {
            ManejoDeControles.FunDesactivarListView(listview, estado);
        }

        public void DesactivarNumericUpDown(NumericUpDown numericupdown, Boolean estado)
        {
            ManejoDeControles.FunDesactivarNumericUpDown(numericupdown, estado);
        }

        public void DesactivarPictureBox(PictureBox picturebox, Boolean estado)
        {
            ManejoDeControles.FunDesactivarPictureBox(picturebox, estado);
        }

        public void DesactivarRadioButton(RadioButton radiobutton, Boolean estado)
        {
            ManejoDeControles.FunDesactivarRadioButton(radiobutton, estado);

        }

        public void DesactivarDataGridView(DataGridView datagridview, Boolean estado)
        {
            ManejoDeControles.FunDesactivarDataGridView(datagridview, estado);

        }

        public void ActivarControles(Control actv)
        {
            foreach (Control c in actv.Controls)
            {
                if (c is Button)
                    ((Button)c).Enabled = true;

                if (c is CheckBox)
                    ((CheckBox)c).Enabled = true;

                if (c is CheckedListBox)
                    ((CheckedListBox)c).Enabled = true;

                if (c is ComboBox)
                    ((ComboBox)c).Enabled = true;

                if (c is DateTimePicker)
                    ((DateTimePicker)c).Enabled = true;

                if (c is ListBox)
                    ((ListBox)c).Enabled = true;

                if (c is ListView)
                    ((ListView)c).Enabled = true;

                if (c is NumericUpDown)
                    ((NumericUpDown)c).Enabled = true;

                if (c is PictureBox)
                    ((PictureBox)c).Enabled = true;

                if (c is RadioButton)
                    ((RadioButton)c).Enabled = true;

                if (c is TextBox)
                    ((TextBox)c).Enabled = true;

                if (c is DataGridView)
                    ((DataGridView)c).Enabled = true;
            }
        }




        #endregion

        //CANCELAR Y LIMPIAR CONTROLES
        #region Limpiar e inhabilitar Controles

        public void LimpiarComponentes(Control control)
        {
            foreach (Control c in control.Controls)
            {

                if (c is CheckBox)
                    ((CheckBox)c).Checked = false;

                if (c is TextBox)
                    ((TextBox)c).Clear();

                if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;

            }
        }

        public void InhabilitarComponentes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Button)
                    ((Button)c).Enabled = false;

                if (c is CheckBox)
                    ((CheckBox)c).Enabled = false;

                if (c is CheckedListBox)
                    ((CheckedListBox)c).Enabled = false;

                if (c is ComboBox)
                    ((ComboBox)c).Enabled = false;

                if (c is DateTimePicker)
                    ((DateTimePicker)c).Enabled = false;

                if (c is ListBox)
                    ((ListBox)c).Enabled = false;

                if (c is ListView)
                    ((ListView)c).Enabled = false;

                if (c is NumericUpDown)
                    ((NumericUpDown)c).Enabled = false;

                if (c is PictureBox)
                    ((PictureBox)c).Enabled = false;

                if (c is RadioButton)
                    ((RadioButton)c).Enabled = false;

                if (c is TextBox)
                    ((TextBox)c).Enabled = false;



            }
        }



        #endregion


    }
}

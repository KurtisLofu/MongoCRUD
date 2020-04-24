using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace Controller
{
    public class Controller1
    {
        IMDBRepository model;
        Form1 form;

        public Controller1()
        {
            model = new IMDBRepository();
            form = new Form1();
            FillDgvPersones();
            FillDgvPelicules();
            AddListeners();
            Application.Run(form);
        }


        public void AddListeners()
        {
            form.tbFiltroPersonas.KeyUp += TbFiltroPersonas_KeyUp;
            form.btnClearFiltrePersones.Click += BtnClearFiltrePersones_Click;
            form.dgvPersones.CellContentClick += DgvPersones_CellContentClick;
            form.btnAfegirPersona.Click += BtnAfegirPersona_Click;
            form.btnModificarPersona.Click += BtnModificarPersona_Click;
            form.btnBuscarPelicula.Click += BtnBuscarPelicula_Click;
            form.dgvPersones.SelectionChanged += DgvPersones_SelectionChanged;
            form.dgvPelicules.SelectionChanged += DgvPelicules_SelectionChanged;
        }

        private void BtnModificarPersona_Click(object sender, EventArgs e)
        {
            Persona p = (Persona)form.dgvPersones.CurrentRow.DataBoundItem;
            p.name = form.tbNomPersona.Text;
            p.pob = form.tbLlocN.Text;
            p.dob = form.dtpDataN.Value.ToString("yyyy-MM-dd");
            p.hasActed = form.cbActor.Checked;
            p.hasDirected = form.cbDirector.Checked;
            try
            {
                model.UpdatePersona(p);
                MessageBox.Show("Modificat satisfactòriament!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar");
            }
            FillDgvPersones();
        }

        private void DgvPersones_SelectionChanged(object sender, EventArgs e)
        {
            if (form.dgvPersones.SelectedRows.Count > 0)
            {
                try
                {
                    Persona p = (Persona)form.dgvPersones.CurrentRow.DataBoundItem;

                    form.tbNomPersona.Text = p.name;
                    form.tbLlocN.Text = p.pob;
                    form.dtpDataN.Value = string.IsNullOrEmpty(p.dob) ? DateTime.MinValue : Convert.ToDateTime(p.dob);
                    form.cbActor.Checked = p.hasActed;
                    form.cbDirector.Checked = p.hasDirected;
                }
                catch (Exception ex)
                {
                    form.tbNomPersona.Text = string.Empty;
                    form.tbLlocN.Text = string.Empty;
                    form.dtpDataN.Value = DateTime.Parse("01/01/1901");
                    form.cbActor.Checked = false;
                    form.cbDirector.Checked = false;
                }
            }
            else
            {
                form.tbNomPersona.Text = string.Empty;
                form.tbLlocN.Text = string.Empty;
                form.dtpDataN.Value = DateTime.Parse("01/01/1901");
                form.cbActor.Checked = false;
                form.cbDirector.Checked = false;
            }
        }

        private void BtnAfegirPersona_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.name = form.tbNomPersona.Text;
            p.pob = form.tbLlocN.Text;
            p.dob = form.dtpDataN.Value.ToString("yyyy-MM-dd");
            p.hasActed = form.cbActor.Checked;
            p.hasDirected = form.cbDirector.Checked;

            try
            {
                model.InsertPersona(p);
                MessageBox.Show("Afegit satisfactòriament!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al afegir");
            }

            FillDgvPersones();
        }

        private void DgvPersones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == form.dgvPersones.Columns["Borrar"].Index && e.RowIndex >= 0)
            {
                string id = form.dgvPersones["name", e.RowIndex].Value.ToString();
                try
                {
                    model.EliminarPersona(id);
                    MessageBox.Show("Esborrat satisfactòriament!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al esborrar");
                }
                FillDgvPersones();
            }

        }

        private void BtnClearFiltrePersones_Click(object sender, EventArgs e)
        {
            FillDgvPersones();
            form.tbFiltroPersonas.Text = string.Empty;
        }

        private void TbFiltroPersonas_KeyUp(object sender, KeyEventArgs e)
        {
            if (form.tbFiltroPersonas.Text.Length > 2)
            {
                form.dgvPersones.DataSource = model.GetListaPersonesFiltrada(form.tbFiltroPersonas.Text);
            }
        }

        public void FillDgvPersones()
        {
            form.dgvPersones.DataSource = model.GetListaPersones();
        }

        private void FillDgvPelicules()
        {
            form.dgvPelicules.DataSource = model.GetPelicules();
        }

        private void BtnBuscarPelicula_Click(object sender, EventArgs e)
        {
            if (form.tbBuscarPelicula.Text.Length > 3)
            {
                if (form.rbActor.Checked)
                    form.dgvPelicules.DataSource = model.GetPeliculesFiltered(form.tbBuscarPelicula.Text, "actors");
                else if (form.rbDirector.Checked)
                    form.dgvPelicules.DataSource = model.GetPeliculesFiltered(form.tbBuscarPelicula.Text, "directors");
                else if (form.rbAny.Checked)
                    form.dgvPelicules.DataSource = model.GetPeliculesFiltered(form.tbBuscarPelicula.Text, "any");
                else if (form.rbNom.Checked)
                    form.dgvPelicules.DataSource = model.GetPeliculesFiltered(form.tbBuscarPelicula.Text, "nom");
            }
        }


        private void DgvPelicules_SelectionChanged(object sender, EventArgs e)
        {
            if (form.dgvPersones.SelectedRows.Count > 0)
            {
                Pelicula p = (Pelicula)form.dgvPelicules.CurrentRow.DataBoundItem;

                form.dgvActors.DataSource = model.GetActorsFromPelicula(p.actors);
                form.dgvDirectors.DataSource = model.GetDirectorsFromPelicula(p.directors);
                form.dgvOscars.DataSource = model.GetOscarsFromPelicula(p);
            }
        }
    }
}

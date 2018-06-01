using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIF
{
    public partial class Principal : Form
    {
        SessionController.Sesion _SESION = SessionController.Sesion.Instance;
        GestionBasica.GUI.GestionRoles frmRoles = new GestionBasica.GUI.GestionRoles();
        GestionBasica.GUI.GestionUsuarios frmUsuarios = new GestionBasica.GUI.GestionUsuarios();
        public Principal()
        {
            InitializeComponent();
            //pnl2.Visible = false;
            //pnl3.Dock = DockStyle.Top;
            pnlSubInicio.Visible = true;
            pnlSubServicios.Visible = false;
            pnlSubInventario.Visible = false;
            pnlSubGestion.Visible = false;
            pnlSubReportes.Visible = false;
            pnlSubInicio.Dock = DockStyle.Top;
            pnlInicio.Visible = true;
            pnlServicios.Visible = false;
            pnlInventario.Visible = false;
            pnlGestion.Visible = false;
            pnlReportes.Visible = false;
            this.btnNuevos.BackColor = Color.OrangeRed;
        }


        private void Principal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _SESION.Usuario;
        }


        //================== ACCION CLICK ========================
        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = true;
            pnlServicios.Visible = false;
            pnlInventario.Visible = false;
            pnlGestion.Visible = false;
            pnlReportes.Visible = false;
            pnlSubInicio.Visible = true;
            pnlSubServicios.Visible = false;
            pnlSubInventario.Visible = false;
            pnlSubGestion.Visible = false;
            pnlSubReportes.Visible = false;
            pnlSubInicio.Dock = DockStyle.Top;
            this.btnNuevos.BackColor = Color.OrangeRed;
            this.btnMasSolicitados.BackColor = Color.DimGray;
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlServicios.Visible = true;
            pnlInventario.Visible = false;
            pnlGestion.Visible = false;
            pnlReportes.Visible = false;
            pnlSubInicio.Visible = false;
            pnlSubServicios.Visible = true;
            pnlSubInventario.Visible = false;
            pnlSubGestion.Visible = false;
            pnlSubReportes.Visible = false;
            pnlSubServicios.Dock = DockStyle.Top;
            this.btnSolicitudPrestamo.BackColor = Color.OrangeRed;
            this.btnPrestamo.BackColor = Color.DimGray;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlServicios.Visible = false;
            pnlInventario.Visible = true;
            pnlGestion.Visible = false;
            pnlReportes.Visible = false;
            pnlSubInicio.Visible = false;
            pnlSubServicios.Visible = false;
            pnlSubInventario.Visible = true;
            pnlSubGestion.Visible = false;
            pnlSubReportes.Visible = false;
            pnlSubInventario.Dock = DockStyle.Top;
            this.btnPorAutor.BackColor = Color.OrangeRed;
            this.btnPorCategoria.BackColor = Color.DimGray;
            this.btnPorEditorial.BackColor = Color.DimGray;
            this.btnPorTitulo.BackColor = Color.DimGray;
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlServicios.Visible = false;
            pnlInventario.Visible = false;
            pnlGestion.Visible = true;
            pnlReportes.Visible = false;
            pnlSubInicio.Visible = false;
            pnlSubServicios.Visible = false;
            pnlSubInventario.Visible = false;
            pnlSubGestion.Visible = true;
            pnlSubReportes.Visible = false;
            pnlSubGestion.Dock = DockStyle.Top;
            this.btnUsuarios.BackColor = Color.OrangeRed;
            this.btnRoles.BackColor = Color.DimGray;
            this.btnPermisos.BackColor = Color.DimGray;
            //-----------------------------------------
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
            frmUsuarios.Dock = DockStyle.Fill;

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlServicios.Visible = false;
            pnlInventario.Visible = false;
            pnlGestion.Visible = false;
            pnlReportes.Visible = true;
            pnlSubInicio.Visible = false;
            pnlSubServicios.Visible = false;
            pnlSubInventario.Visible = false;
            pnlSubGestion.Visible = false;
            pnlSubReportes.Visible = true;
            pnlSubReportes.Dock = DockStyle.Top;
            this.btnLibrosPrestados.BackColor = Color.OrangeRed;
            this.btnLibrosDevueltos.BackColor = Color.DimGray;
            this.btnInventarios.BackColor = Color.DimGray;

        }

        //============================================================================



        //========================= EFECTO HOVER MENU ===============================
        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            this.btnInicio.BackColor = Color.OrangeRed;
        }

        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            this.btnInicio.BackColor = SystemColors.ControlText;
        }

        private void btnServicios_MouseEnter(object sender, EventArgs e)
        {
            this.btnServicios.BackColor = Color.OrangeRed;
        }

        private void btnServicios_MouseLeave(object sender, EventArgs e)
        {
            this.btnServicios.BackColor = SystemColors.ControlText;
        }

        private void btnInventario_MouseEnter(object sender, EventArgs e)
        {
            this.btnInventario.BackColor = Color.OrangeRed;
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            this.btnInventario.BackColor = SystemColors.ControlText;
        }

        private void btnGestion_MouseEnter(object sender, EventArgs e)
        {
            this.btnGestion.BackColor = Color.OrangeRed;
        }

        private void btnGestion_MouseLeave(object sender, EventArgs e)
        {
            this.btnGestion.BackColor = SystemColors.ControlText;
        }

        private void btnReportes_MouseEnter(object sender, EventArgs e)
        {
            this.btnReportes.BackColor = Color.OrangeRed;
        }

        private void btnReportes_MouseLeave(object sender, EventArgs e)
        {
            this.btnReportes.BackColor = SystemColors.ControlText;
        }

        //==============================================================



        //================== ACCION CLICK SUB MENU =====================
        private void button1_Click(object sender, EventArgs e)
        {
            this.btnNuevos.BackColor = Color.OrangeRed;
            this.btnMasSolicitados.BackColor = Color.DimGray;
        }

        private void btnMasSolicitados_Click(object sender, EventArgs e)
        {
            this.btnNuevos.BackColor = Color.DimGray;
            this.btnMasSolicitados.BackColor = Color.OrangeRed;
        }

        private void btnSolicitudPrestamo_Click(object sender, EventArgs e)
        {
            this.btnSolicitudPrestamo.BackColor = Color.OrangeRed;
            this.btnPrestamo.BackColor = Color.DimGray;
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            this.btnSolicitudPrestamo.BackColor = Color.DimGray;
            this.btnPrestamo.BackColor = Color.OrangeRed;
        }

        private void btnPorAutor_Click(object sender, EventArgs e)
        {
            this.btnPorAutor.BackColor = Color.OrangeRed;
            this.btnPorCategoria.BackColor = Color.DimGray;
            this.btnPorEditorial.BackColor = Color.DimGray;
            this.btnPorTitulo.BackColor = Color.DimGray;
        }

        private void btnPorCategoria_Click(object sender, EventArgs e)
        {
            this.btnPorAutor.BackColor = Color.DimGray;
            this.btnPorCategoria.BackColor = Color.OrangeRed;
            this.btnPorEditorial.BackColor = Color.DimGray;
            this.btnPorTitulo.BackColor = Color.DimGray;
        }

        private void btnPorEditorial_Click(object sender, EventArgs e)
        {
            this.btnPorAutor.BackColor = Color.DimGray;
            this.btnPorCategoria.BackColor = Color.DimGray;
            this.btnPorEditorial.BackColor = Color.OrangeRed;
            this.btnPorTitulo.BackColor = Color.DimGray;
        }

        private void btnPorTitulo_Click(object sender, EventArgs e)
        {
            this.btnPorAutor.BackColor = Color.DimGray;
            this.btnPorCategoria.BackColor = Color.DimGray;
            this.btnPorEditorial.BackColor = Color.DimGray;
            this.btnPorTitulo.BackColor = Color.OrangeRed;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.btnUsuarios.BackColor = Color.OrangeRed;
            this.btnRoles.BackColor = Color.DimGray;
            this.btnPermisos.BackColor = Color.DimGray;
            //----------------------------------------
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
            frmUsuarios.Dock = DockStyle.Fill;
            frmUsuarios.BringToFront();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            this.btnUsuarios.BackColor = Color.DimGray;
            this.btnRoles.BackColor = Color.OrangeRed;
            this.btnPermisos.BackColor = Color.DimGray;
            //-----------------------------------------
            
            frmRoles.MdiParent = this;
            frmRoles.Show();
            frmRoles.Dock = DockStyle.Fill;
            frmRoles.BringToFront();

        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            this.btnUsuarios.BackColor = Color.DimGray;
            this.btnRoles.BackColor = Color.DimGray;
            this.btnPermisos.BackColor = Color.OrangeRed;
        }

        private void btnLibrosPrestados_Click(object sender, EventArgs e)
        {
            this.btnLibrosPrestados.BackColor = Color.OrangeRed;
            this.btnLibrosDevueltos.BackColor = Color.DimGray;
            this.btnInventarios.BackColor = Color.DimGray;
        }

        private void btnLibrosDevueltos_Click(object sender, EventArgs e)
        {
            this.btnLibrosPrestados.BackColor = Color.DimGray;
            this.btnLibrosDevueltos.BackColor = Color.OrangeRed;
            this.btnInventarios.BackColor = Color.DimGray;
        }

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            this.btnLibrosPrestados.BackColor = Color.DimGray;
            this.btnLibrosDevueltos.BackColor = Color.DimGray;
            this.btnInventarios.BackColor = Color.OrangeRed;
        }

        //---------------------------------------------------------------
    }
}

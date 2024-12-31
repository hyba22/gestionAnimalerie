using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AnimalerieProjet.components;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace AnimalerieProjet
{
    public partial class dashboard : Form
    {
        // declaring field for left menu icons and for other forms 
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        // constructor
        public dashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            //panel menu 
            panel1.Controls.Add(leftBorderBtn);

            // to hide the dash controlBox 
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            // to make the window same as the laptop screen 
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        //design methods
        // 1 : method for active btn 
        private void ActiveBtn(Object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                // to deactivate the previous btn  
                DisableBtn();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.DarkMagenta;
                currentBtn.ForeColor = Color.LavenderBlush;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // left border btn 
                leftBorderBtn.BackColor = Color.GhostWhite;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }

        }

        //2 : method to disable btn highlight
        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Thistle;
                currentBtn.ForeColor = Color.DarkMagenta;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.LavenderBlush;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        // drag form : so we can move it by holding the body panel and menu panel (panel1)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint ="SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void bodyPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // 3 : method to make the title panel "Admin Dashboard" redirect to home and close everything 
       
        private void panel2_Click(object sender, EventArgs e)
        {
            Reset();  
        }

        private void Reset()
        {
            DisableBtn();
            leftBorderBtn.Visible = false;
            currentChildForm.Visible = false;
        }

        // method 4 : to open the other entities in the same window and in the right panel 
        private void OpenChild(Form childForm)
        {
            if (currentChildForm != null)
            {
                // open only form
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;  
            childForm.Dock = DockStyle.Fill;
            bodyPanel.Controls.Add(childForm);
            bodyPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        // redirect to product page
        private void produitBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, Color.White);
            OpenChild(new Produits());
        }
        //redirect to clients page
        private void clientsBtn_Click_1(object sender, EventArgs e)
        {
            ActiveBtn(sender, Color.White);
            OpenChild(new Clients());
        }

        //redirect to commandes page
        private void commandeBtn_Click(object sender, EventArgs e)
        {   
            ActiveBtn(sender, Color.White);
            OpenChild(new Commandes());
        }
        // logout btn
        
        private void logoutbtn_Click(object sender, EventArgs e)
        {   
            ActiveBtn(sender, Color.White);
            login log = new login();
            log.Show();
            this.Close();
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bodyPanel_MouseEnter(object sender, EventArgs e)
        {

        }
        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dashTitle_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

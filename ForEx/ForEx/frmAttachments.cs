using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForEx.Classes;

namespace ForEx
{
    public partial class frmAttachments : Form
    {
        private int userid;
        private SqlConnection con = new SqlConnection(Common.GetConnectionString());
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlCommand cmd = new SqlCommand();

        public frmAttachments()
        {
            InitializeComponent();
        }

        public frmAttachments(int userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Uploads> downloadFileFromDatabase(int userid)
        {
            SqlConnection con = new SqlConnection(Common.GetConnectionString());
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            SqlParameter kFileName = null;
            SqlParameter fileName = null;
            SqlDataReader dr = null;
            List<Uploads> listimages = new List<Uploads>();

            try
            {
                //
                // Connecting to database.
                //
                cmd = new SqlCommand("SELECT * FROM [tbl_UserUpload] WHERE userid = '" + userid.ToString() + "'");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                // ----------------------------------------------


                con.Open();
                dr = cmd.ExecuteReader();
                dr.Read();

                
                
                if (dr.HasRows)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(dr);
                    foreach (DataRow row in myTable.Rows)
                    {
                        var upload = new Uploads
                        {
                            image = (byte[]) row["imageuploaded"],
                            imagename = row["imagename"].ToString()
                        };

                        listimages.Add(upload);
                    }
                }

                dr.Close();
                con.Close();
                // ------------------------------------------

                //
                // Disposing of the objects so we don't occupy memory.
                //
                con.Dispose();
                cmd.Dispose();
                // ------------------------------------------
            }
            catch (Exception e)
            {
                //
                // If an error occurs, we assign null
                // to the result and display the error to the user,
                // with information about the StackTrace for debugging purposes.
                //
                Console.WriteLine(e.Message + " - " + e.StackTrace);
                listimages = null;
            }
            return listimages;
        }

        private void frmAttachments_Load(object sender, EventArgs e)
        {
            var imagelist = downloadFileFromDatabase(userid);

            for (int i = 0; i < imagelist.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        BindImages(imagelist.ElementAt(i).image, pictureBox1);
                        break;

                    case 1:
                        BindImages(imagelist.ElementAt(i).image, pictureBox2);

                        break;

                    case 2:
                        BindImages(imagelist.ElementAt(i).image, pictureBox3);

                        break;

                    case 3:
                        BindImages(imagelist.ElementAt(i).image, pictureBox4);

                        break;

                    case 4:
                        BindImages(imagelist.ElementAt(i).image, pictureBox5);

                        break;

                    default:
                        break;

                }
            }
        }

        private void BindImages(byte[] image, PictureBox pb)
        {
            try
            {
                //
                // We cannot assign a byte array directly to an image. 
                // We use MemoryStream, an object that creates a file in memory
                //  and than we pass this to create the image object.
                //
                MemoryStream ms = new MemoryStream(image, 0, image.Length);
                Image im = Image.FromStream(ms);
                pb.Image = im;
            }
            catch (Exception ee)
            {
                MessageBox.Show("An error has occured.\n" + ee.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var image = pictureBox1.Image;
            pictureBox6.Image = image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var image = pictureBox2.Image;
            pictureBox6.Image = image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var image = pictureBox3.Image;
            pictureBox6.Image = image;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var image = pictureBox4.Image;
            pictureBox6.Image = image;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var image = pictureBox5.Image;
            pictureBox6.Image = image;
        }

    }
}

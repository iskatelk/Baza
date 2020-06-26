using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace BazaDanix3
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListBox listBox4;
		private System.Windows.Forms.MenuItem menuItemEx;
		private System.Windows.Forms.MenuItem menuItemE;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.MainMenu mainMenu1;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItemE = new System.Windows.Forms.MenuItem();
			this.menuItemEx = new System.Windows.Forms.MenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox4 = new System.Windows.Forms.ListBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItemE);
			// 
			// menuItemE
			// 
			this.menuItemE.MenuItems.Add(this.menuItemEx);
			this.menuItemE.Text = "Меню";
			this.menuItemE.Click += new System.EventHandler(this.menuItemEx_Click);
			// 
			// menuItemEx
			// 
			this.menuItemEx.Text = "Завершить";
			this.menuItemEx.Click += new System.EventHandler(this.menuItemEx_Click_1);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(240, 256);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.listBox1);
			this.tabPage1.Controls.Add(this.listBox4);
			this.tabPage1.Location = new System.Drawing.Point(4, 4);
			this.tabPage1.Size = new System.Drawing.Size(232, 230);
			this.tabPage1.Text = "Главная";
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(72, 8);
			this.listBox1.Size = new System.Drawing.Size(144, 210);
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// listBox4
			// 
			this.listBox4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular);
			this.listBox4.Items.Add("А");
			this.listBox4.Items.Add("Б");
			this.listBox4.Items.Add("В");
			this.listBox4.Items.Add("Г");
			this.listBox4.Items.Add("Д");
			this.listBox4.Items.Add("Е");
			this.listBox4.Items.Add("Ж");
			this.listBox4.Items.Add("З");
			this.listBox4.Items.Add("И");
			this.listBox4.Items.Add("Й");
			this.listBox4.Items.Add("К");
			this.listBox4.Items.Add("Л");
			this.listBox4.Items.Add("М");
			this.listBox4.Items.Add("Н");
			this.listBox4.Items.Add("О");
			this.listBox4.Items.Add("П");
			this.listBox4.Items.Add("Р");
			this.listBox4.Items.Add("С");
			this.listBox4.Items.Add("Т");
			this.listBox4.Items.Add("У");
			this.listBox4.Items.Add("Ф");
			this.listBox4.Items.Add("Х");
			this.listBox4.Items.Add("Ц");
			this.listBox4.Items.Add("Ч");
			this.listBox4.Items.Add("Ш");
			this.listBox4.Items.Add("Э");
			this.listBox4.Items.Add("Ю");
			this.listBox4.Items.Add("Я");
			this.listBox4.Location = new System.Drawing.Point(8, 8);
			this.listBox4.Size = new System.Drawing.Size(40, 212);
			this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.listBox3);
			this.tabPage2.Controls.Add(this.listBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 4);
			this.tabPage2.Size = new System.Drawing.Size(232, 230);
			this.tabPage2.Text = "Позиции";
			// 
			// listBox3
			// 
			this.listBox3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular);
			this.listBox3.Location = new System.Drawing.Point(0, 176);
			this.listBox3.Size = new System.Drawing.Size(240, 86);
			this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
			// 
			// listBox2
			// 
			this.listBox2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular);
			this.listBox2.Location = new System.Drawing.Point(8, 8);
			this.listBox2.Size = new System.Drawing.Size(208, 156);
			this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.pictureBox1);
			this.tabPage3.Location = new System.Drawing.Point(4, 4);
			this.tabPage3.Size = new System.Drawing.Size(232, 230);
			this.tabPage3.Text = "Картинка";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(8, 0);
			this.pictureBox1.Size = new System.Drawing.Size(232, 230);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(240, 256);
			this.Controls.Add(this.tabControl1);
			this.Menu = this.mainMenu1;
			this.Text = "Боны - закупки";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ParentChanged += new System.EventHandler(this.menuItemEx_Click);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		static void Main() 
		{
			Application.Run(new Form1());
			
		}

		
		
		System.Data.DataSet m_myDataSet;

		private bool m_indexLookedUp = false;
		private const int INVALID_INDEX = -1;
		private int m_IndexOfTestColumn_Strana = INVALID_INDEX;
		private int m_IndexOfTestColumn_Edinica = INVALID_INDEX;
		private int m_IndexOfTestTable = INVALID_INDEX;
		private string str;

		System.Data.DataColumn m_TestColumn_Strana;
		System.Data.DataColumn m_TestColumn_Edinica;
		private System.Data.DataTable m_TableZakupkiInfo;

		const string TABLE_NAME_ZAKUPKI = "Zakupki";
		const string COLUMN_NAME_STRANA = "Strana";
		const string COLUMN_NAME_EDINICA = "Edinica";
		const string COLUMN_NAME_CENA = "Cena";
		const string COLUMN_NAME_KOLVO = "Kolvo";
		const string COLUMN_NAME_KARTINKA = "Kartinka";
		
		private void createDataSet()
		{
			m_myDataSet = new System.Data.DataSet ("Spisok zakupok");

			System.Data.DataTable myTestTable;
			myTestTable = m_myDataSet.Tables.Add(TABLE_NAME_ZAKUPKI);

			myTestTable.Columns.Add(COLUMN_NAME_STRANA, typeof(string));

			myTestTable.Columns.Add(COLUMN_NAME_EDINICA, typeof(string));

			myTestTable.Columns.Add(COLUMN_NAME_CENA, typeof(string));

			myTestTable.Columns.Add(COLUMN_NAME_KOLVO, typeof(string));

			myTestTable.Columns.Add(COLUMN_NAME_KARTINKA, typeof(string));


			object[] objArray;
			objArray = new object[5];
			
			System.IO.FileStream fs;
			System.IO.StreamReader sr;
			
//			fs = new System.IO.FileStream("c:/Proba/test.txt", System.IO.FileMode.OpenOrCreate,System.IO.FileAccess.Read);
			fs = new System.IO.FileStream("/SD Card/Bona Sales/test.txt", System.IO.FileMode.OpenOrCreate,System.IO.FileAccess.Read);
			sr = new System.IO.StreamReader(fs);
			
			long offset = 0;
			sr.BaseStream.Seek( offset , System.IO.SeekOrigin.Begin);
			while (sr.Peek() > -1)
			{
				string res;
				
				      
				res = sr.ReadLine();
				 
				int ix = res.LastIndexOf(";" ) ;
				//ls = res.Substring(ix+1); 	
				objArray[4] = res.Substring(ix+1);
				res = res.Substring(0, ix);
				ix = res.LastIndexOf(";" ) ;
				objArray[3] = res.Substring(ix+1);
				res = res.Substring(0, ix);
				ix = res.LastIndexOf(";" ) ;
				objArray[2] = res.Substring(ix+1);
				res = res.Substring(0, ix);
				ix = res.LastIndexOf(";" ) ;
				objArray[1] = res.Substring(ix+1);
				res = res.Substring(0, ix);
				ix = res.LastIndexOf(";" ) ;
				//ls = res.Substring(ix+1);
				objArray[0] = res.Substring(ix+1);
								   
				myTestTable.Rows.Add(objArray);
			}
				
			sr.Close();
			fs.Close();

		
		}
	
			

		private void cacheDataSetInfo()
		{
			if (m_indexLookedUp == true) {return;}

			m_IndexOfTestTable = m_myDataSet.Tables.IndexOf(TABLE_NAME_ZAKUPKI);

			m_TableZakupkiInfo = m_myDataSet.Tables[m_IndexOfTestTable];
			int dataColumnCount = m_TableZakupkiInfo.Columns.Count;
			System.Data.DataColumn myColumn;

			for(int colIdx = 0; colIdx < dataColumnCount;)
			{
				myColumn = m_TableZakupkiInfo.Columns[colIdx];

				if(m_IndexOfTestColumn_Strana == INVALID_INDEX)
				{
					if (myColumn.ColumnName == COLUMN_NAME_STRANA)
					{
						m_IndexOfTestColumn_Strana = colIdx;
						m_TestColumn_Strana = myColumn;
						goto next_loop_iteration;
					}
				}

				if(m_IndexOfTestColumn_Edinica== INVALID_INDEX)
				{
					if (myColumn.ColumnName == COLUMN_NAME_EDINICA)
					{
						m_IndexOfTestColumn_Edinica=colIdx;
						m_TestColumn_Edinica= myColumn;
						goto next_loop_iteration;
					}
				}
			next_loop_iteration:
				colIdx++;
			}
			m_indexLookedUp = true;
		}

		
				
		

		
		/*	

			private void buttonD_Click(object sender, System.EventArgs e)
			{
				listBox1.Items.Clear();
				System.Data.DataTable dataTable_Zakupki = m_TableZakupkiInfo;
			
				foreach (DataRow currentZakupkiRow in dataTable_Zakupki.Rows)
				{
					string currentStrana;
					//string currentEdinica;
					currentStrana = (string) currentZakupkiRow[m_TestColumn_Strana];
					//currentEdinica = (string) currentZakupkiRow[m_TestColumn_Edinica];
					if(currentStrana.StartsWith("Д"))
					{
						if (listBox1.Items.IndexOf(currentStrana) == -1)
						{
							listBox1.Items.Add(currentStrana);
							
						} 
					}
				
				}

			}*/

		//string c;
		private void listBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			listBox3.Items.Clear();
			System.Data.DataTable dataTable_Zakupki = m_TableZakupkiInfo;
			
			foreach (DataRow currentZakupkiRow in dataTable_Zakupki.Rows)
			{
				string currentStrana;
				string currentEdinica;
				string currentStr;
				string currentEd;
				
				currentStr = listBox1.Text;
				currentEd = listBox2.Text;
				currentStrana = (string) currentZakupkiRow[m_TestColumn_Strana];
				currentEdinica = (string) currentZakupkiRow[m_TestColumn_Edinica];
				if((currentStrana == currentStr)&&(currentEdinica == currentEd))
				{
					string cn = "Цена: ";
					string cnb = (string) currentZakupkiRow["Cena"];
					string poz = String.Concat(cn,cnb);
					//					listBox3.Items.Add(currentStrana);
					int ix = currentEdinica.LastIndexOf("-" ) ;
					listBox3.Items.Add(currentEdinica.Substring(ix+2));
					currentEdinica = currentEdinica.Substring(0, ix);
					
					listBox3.Items.Add(currentEdinica);
					listBox3.Items.Add(poz);
					
					listBox3.Items.Add((string) currentZakupkiRow["Kolvo"]);
					listBox3.Items.Add((string) currentZakupkiRow["Kartinka"]);
					str = (string) currentZakupkiRow["Kartinka"];
 
				}
			}
			System.Drawing.Bitmap mybitmap1;
//			string stroka = "d:/products_pictures/";
			string stroka = "/SD Card/products_pictures/";
			string ck = String.Concat(stroka, str);
			//System.Windows.Forms.MessageBox.Show(ck);
			mybitmap1 = new System.Drawing.Bitmap(ck);
			//		    listBox3.Items.Add( mybitmap1.Width);
			//			listBox3.Items.Add( mybitmap1.Height);

			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.Image = mybitmap1;

		}

		


			
	

	

		private void listBox4_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			listBox1.Items.Clear();
			listBox2.Items.Clear();
			listBox3.Items.Clear();
			System.Data.DataTable dataTable_Zakupki = m_TableZakupkiInfo;
			
			foreach (DataRow currentZakupkiRow in dataTable_Zakupki.Rows)
			{
				string currentStrana;
				
				currentStrana = (string) currentZakupkiRow[m_TestColumn_Strana];
				//currentEdinica = (string) currentZakupkiRow[m_TestColumn_Edinica];
				if(currentStrana.StartsWith(listBox4.Text))
				{
					if (listBox1.Items.IndexOf(currentStrana) == -1)
					{
						listBox1.Items.Add(currentStrana);
							
					} 
				}
			}
		}

	

	

		

		private void menuItemEx_Click_1(object sender, System.EventArgs e)
		{
			Application.Exit();

		}

		private void menuItemEx_Click(object sender, System.EventArgs e)
		{
		
		}
		
		
		

		private void Form1_Load(object sender, System.EventArgs e)
		{
			createDataSet();
			cacheDataSetInfo();
		}

		private void tabPage1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)

		{
			//			System.Windows.Forms.MessageBox.Show(ck);
			string text;
			MouseButtons button;
			button = e.Button;
			if (button == MouseButtons.Left)
				{
					text = "левую";
				}

				else if(button == MouseButtons.Right)
	
	            {
		           text = "правую";
				}
		else
				{
					text = "среднюю";
				}
	
	string message = "Вы нажали " + text + " кнопку мыши в координатах:\n"+
	"х:= " + e.X.ToString() + "\n" +
	"у:= " + e.Y.ToString () ;
	MessageBox.Show(message);
}

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			listBox2.Items.Clear();
			listBox3.Items.Clear();
			
			System.Data.DataTable dataTable_Zakupki = m_TableZakupkiInfo;
			
			foreach (DataRow currentZakupkiRow in dataTable_Zakupki.Rows)
			{
				string currentStrana;
				string currentEdinica;
				string currentStr;
				
				currentStr = listBox1.Text;
				currentStrana = (string) currentZakupkiRow[m_TestColumn_Strana];
				currentEdinica = (string) currentZakupkiRow[m_TestColumn_Edinica];
				if(currentStrana == currentStr)
				{
					
						
					listBox2.Items.Add(currentEdinica);
							
					 
				}
			}
	
		}

	


/*
		private void hScrollBar1_ValueChanged(object sender, System.EventArgs e)
		{
			Value = (int)hScrollBar1.Value;
			
			pictureBox1.Location = new Point(Value,Value2);
		}

		private void vScrollBar1_ValueChanged(object sender, System.EventArgs e)
		{
			Value2 = (int)vScrollBar1.Value;
				
			pictureBox1.Location = new Point(Value,Value2);

		} */



	}
}

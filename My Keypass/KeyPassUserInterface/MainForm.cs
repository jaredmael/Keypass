using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyPassBusiness;
using System.IO;
using System.Reflection;
using System.Xml;
using KeyPassInfoObjects;
using System.Drawing.Printing;
using System.Runtime.Serialization;
using DropNet;





namespace KeyPassUserInterface
{

	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

        private String FontSelected;
        private int FontSize;

		#region Public Functions

		public void Save()
		{
			
			if (KeyChainManager.isNamed != String.Empty)
			{
				PasswordForm s = new PasswordForm();
				s.ShowDialog();
				string newpass = s.Password;
				if (s.DialogResult != DialogResult.OK)
				{
					return;
				}
				KeyChain d = KeyChainManager.KeyChain;
				if (File.Exists(d.Name))
				{
					File.Delete(d.Name);
				}
			
				
                MemoryStream memoryStream = new MemoryStream();
				KeyChainManager.KeyChain.IsModified = false;
                DataContractSerializer dcs = new DataContractSerializer(typeof(KeyChain));
                dcs.WriteObject(memoryStream, KeyChainManager.KeyChain);
				Byte[] ToWrite = CryptoHelper.Encrypt(memoryStream.ToArray(), newpass);
                File.WriteAllBytes(d.Name, ToWrite);
                memoryStream.Close();

                //Disabled for demo. uncomment to use
                //DropNetClient Dropbox;
                //nextline needs tokens and keys to get dropbox working. Disabled for demo
                //Dropbox = new DropNetClient();
                //Dropbox.UseSandbox = true;
                //var uploaded = Dropbox.UploadFile("/", Path.GetFileName(d.Name), ToWrite);
				
				

			
			}
			else
			{
                
				SaveFileDialog d = new SaveFileDialog();
				string exe = Assembly.GetExecutingAssembly().Location;
				d.InitialDirectory = Path.GetDirectoryName(exe);
				d.RestoreDirectory = true;
				d.Filter = "KeyChain Files|*.kcf";
				if (d.ShowDialog(this) != DialogResult.OK)
					return;
				else
				{
					PasswordForm s = new PasswordForm();
					s.ShowDialog();
					string newpass = s.Password;
					if (s.DialogResult != DialogResult.OK)
					{
						return;
					}

                    KeyChainManager.isNamed = d.FileName;
                    MemoryStream memoryStream = new MemoryStream();
                    Text = d.FileName;
                    KeyChainManager.KeyChain.IsModified = false;
                    DataContractSerializer dcs = new DataContractSerializer(typeof(KeyChain));
                    dcs.WriteObject(memoryStream, KeyChainManager.KeyChain);
                    Byte[] ToWrite = CryptoHelper.Encrypt(memoryStream.ToArray(), newpass);
                    File.WriteAllBytes(d.FileName, ToWrite);
                    memoryStream.Close();

                    //Dropbox removed for demo
                    //DropNetClient Dropbox;
                    //enter Tokens and keys in next line to use dropbox.  Removed for demo
                    //Dropbox = new DropNetClient();
                    //Dropbox.UseSandbox = true;
                    //var uploaded = Dropbox.UploadFile("/", Path.GetFileName(d.FileName), ToWrite);

				}
			}

		}
		  
		public void OpenfromDropBox()
		{
			//Dropbox disabled for demo
			//DropNetClient Dropbox;
            //enter Tokens and keys in next line to use dropbox.  Removed for demo
			//Dropbox = new DropNetClient();
            //Dropbox.UseSandbox = true;
            //DropboxOpen d= new DropboxOpen();
            //d.ShowDialog();
            //if (d.DialogResult == DialogResult.OK)
            //{
            //    if (d.Fchosen != null)
            //    {
            //        string pass = d.pw;
            //        MDIChildForm form = new MDIChildForm();
            //        form.Fsize = this.FontSize;
            //        form.Ftype = this.FontSelected;
            //        form.MdiParent = this;
            //        form.Show();
            //        string dropboxpath = "/" + Path.GetFileName(d.Fchosen);
            //        var downloaded = Dropbox.GetFile(dropboxpath);
            //        byte[] encryptedbytes = downloaded.ToArray();
            //        DataContractSerializer dcs = new DataContractSerializer(typeof(KeyChain));
            //        byte[] decryptedArray = CryptoHelper.Decrypt(encryptedbytes, pass);
            //        if (decryptedArray != null)
            //        {
            //            MemoryStream memoryreadStream = new MemoryStream(decryptedArray);
            //            KeyChainManager.KeyChain = (KeyChain)dcs.ReadObject(memoryreadStream);
            //            memoryreadStream.Close();
            //            form.LoadFile();
            //        }
            //        else
            //        {
            //            form.Close();
            //            MessageBox.Show("Wrong Password Entered.  Please try to load File again, select a different file, create a new file, or exit.");
            //        }
            //    }
			
            //else if(d.DialogResult==DialogResult.Cancel)
            //{
				Open();
			//}
		}

		public void Open()
		{
						OpenFileDialog d = new OpenFileDialog();
						if (d.FileName != null)
						{
					
							string exe = Assembly.GetExecutingAssembly().Location;
							d.InitialDirectory = Path.GetDirectoryName(exe);
							d.RestoreDirectory = true;
							d.Filter = "KeyChain Files|*.kcf";
							if (d.ShowDialog(this) != DialogResult.OK)
								return;
							else
							{
								PasswordForm p = new PasswordForm();
								p.local =File.ReadAllBytes(d.FileName);
								p.savethis = 2;
								p.ShowDialog();
								if (p.DialogResult != DialogResult.OK)
								{
									return;
								}
								string pass = p.Password;
								MDIChildForm form = new MDIChildForm();
                                form.Fsize = this.FontSize;
                                form.Ftype = this.FontSelected;
								form.MdiParent = this;
								form.Show();
								

								DataContractSerializer dcs = new DataContractSerializer(typeof(KeyChain));
								byte[] ToRead = File.ReadAllBytes(d.FileName);
								byte[]decryptedArray = CryptoHelper.Decrypt(ToRead,pass);
								if (decryptedArray != null)
								{
									MemoryStream memoryreadStream = new MemoryStream(decryptedArray);
									KeyChainManager.KeyChain = (KeyChain)dcs.ReadObject(memoryreadStream);
									memoryreadStream.Close();
									form.LoadFile();
									//foreach (Group g in KeyChainManager.KeyChain.Groups)
									//{
									//form.groupTreeControl1.AddTreeNodefromFileLoad(g);
									//statusStripGroupTotal(g);
									//}

									statusStripControl1.StatusBarComboboxClear();
									KeyChainManager.KeyChain.IsModified = false;
									Text = d.FileName;
								}
								else
								{
									form.Close();
									MessageBox.Show("Wrong Password Entered.  Please try to load File again, select a different file, create a new file, or exit.");
								}
							}
		
						}

				

							statusStripControl1.StatusBarComboboxClear();
							KeyChainManager.KeyChain.IsModified = false;
							Text = d.FileName;
						
		}
		 

		public void New()
		{
			MDIChildForm form = new MDIChildForm();
            form.Fsize = this.FontSize;
            form.Ftype = this.FontSelected;
			form.MdiParent = this;
			form.Show();
		}

		#endregion

		#region ToolStrip Functions
		public void ToolStripAboutButton_Click(object sender, EventArgs e)
		{
			AboutForm about = new AboutForm();
			about.ShowDialog();
		}

		private void ToolStripPrint_Click(object sender, EventArgs e)
		{
			PrintNow();
		}

		private void ToolStripSave_Click(object sender, EventArgs e)
		{
			Save();	
		}

		private void ToolStripNew_Click(object sender, EventArgs e)
		{
			New();
		}

		private void ToolStripOpen_Click(object sender, EventArgs e)
		{
			OpenfromDropBox();
		}
		
		#endregion

		#region MenuStrip Functions
		private void FileSaveAs_Click(object sender, EventArgs e)
		{
			
			SaveFileDialog d = new SaveFileDialog();
				string exe = Assembly.GetExecutingAssembly().Location;
				d.InitialDirectory = Path.GetDirectoryName(exe);
				d.RestoreDirectory = true;
				d.Filter = "KeyChain Files|*.kcf";
				if (d.ShowDialog(this) != DialogResult.OK)
					return;
				else
				{
					PasswordForm s = new PasswordForm();
					s.ShowDialog();
					string newpass = s.Password;
					if (s.DialogResult != DialogResult.OK)
					{
						return;
					}
					KeyChainManager.isNamed = d.FileName;
					MemoryStream memoryStream = new MemoryStream();
					Text = d.FileName;
					KeyChainManager.KeyChain.IsModified = false;
					DataContractSerializer dcs = new DataContractSerializer(typeof(KeyChain));
					dcs.WriteObject(memoryStream, KeyChainManager.KeyChain);
					Byte[] ToWrite = CryptoHelper.Encrypt(memoryStream.ToArray(),newpass);
					File.WriteAllBytes(d.FileName, ToWrite);
					memoryStream.Close();

                    //commented out for demo
                    //DropNetClient Dropbox;
                    //add tokens and keys in next line to use dropbox.  Deleted for demo
                    //Dropbox = new DropNetClient();
                    //Dropbox.UseSandbox = true;
                    //var uploaded = Dropbox.UploadFile("/", Path.GetFileName(d.FileName), ToWrite);
				}

		}

		private void FileMenuOpening(object sender, EventArgs e)
		{
			FileSave.Enabled = FileSaveAs.Enabled = KeyChainManager.isModified;
		}

		private void FileNew_Click(object sender, EventArgs e)
		{
			New();
		}

		private void FileOpen_Click(object sender, EventArgs e)
		{
			OpenfromDropBox();
		}

		private void FileSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void FilePrint_Click(object sender, EventArgs e)
		{
			PrintNow();
		}

		private void FileExit_onClick(object sender, EventArgs e)
		{
				Close();
		}
		

		
		private void EditAddGroup_Click(object sender, EventArgs e)
		{
			MDIChildForm x = (MDIChildForm)ActiveMdiChild;
			x.Groupadd();
		}

		private void EditEditGroup_Click(object sender, EventArgs e)
		{
			MDIChildForm x = (MDIChildForm)ActiveMdiChild;
			x.GroupEdit();
		}

		private void EditDeleteGroup_Click(object sender, EventArgs e)
		{
			MDIChildForm x = (MDIChildForm)ActiveMdiChild;
			x.GroupDelete();
		}



		private void EditAddEntry_Click(object sender, EventArgs e)
		{
			MDIChildForm x = (MDIChildForm)ActiveMdiChild;
			x.KeyAdd();
		}

		private void EditEditEntry_Click(object sender, EventArgs e)
		{
			MDIChildForm x = (MDIChildForm)ActiveMdiChild;
			x.KeyEdit();
		}

		private void EditDeleteEntry_Click(object sender, EventArgs e)
		{
			MDIChildForm x = (MDIChildForm)ActiveMdiChild;
			x.GroupDelete();
		}

		private void ViewToolbar_onCheck(object sender, EventArgs e)
		{
			if (ViewToolbar.Checked == true)
			{
				toolStrip1.Visible = true;
			}
			else
			{
				toolStrip1.Visible = false;
			}
		}

		private void ViewStatusBar_onCheck(object sender, EventArgs e)
		{
			if (ViewStatusBar.Checked == true)
			{
				statusStripControl1.Visible = true;
			}
			else
			{
				statusStripControl1.Visible = false;
			}

		}

		private void WindowArrangeTileHorizontally_OnClick(object sender, EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
		}

		private void WindowArrangeTileVertically_OnClick(object sender, EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
		}

		private void WindowArrangeTileCascade_OnClick(object sender, EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
		}

		private void HelpAbout_Click(object sender, EventArgs e)
		{
			AboutForm about = new AboutForm();
			about.ShowDialog();
		}
		
		
		#endregion

		#region Other Functions


		private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
		{

		}

		#region dragdrop not used
		private void MainForm_DragDropped(object sender, DragEventArgs e)
		{
			/*
			if (KeyChainManager.isModified == true)
			{
				DialogResult dr = MessageBox.Show("Current document has unsaved changes. Save Changes? ", "My Keypass",
					MessageBoxButtons.YesNoCancel);
				if (dr == DialogResult.Cancel)
				{
					return;
				}
				else if (dr == DialogResult.Yes)
				{
					Save();
					if (KeyChainManager.isModified == false)
					{
						string[] f = (string[])e.Data.GetData(DataFormats.FileDrop);
						string fileName = f[0];

						KeyChainManager.newKeyChain();
						groupTreeControl1.resetView();
						keyListControl1.resetView();
						keyDetailControl1.resetView();

						DataContractSerializer dcs = new DataContractSerializer(typeof(KeyChain));
						byte[] ToRead = File.ReadAllBytes(fileName);
						byte[] decryptedArray = CryptoHelper.Decrypt(ToRead);
						MemoryStream memoryreadStream = new MemoryStream(decryptedArray);
						KeyChainManager.KeyChain = (KeyChain)dcs.ReadObject(memoryreadStream);
						memoryreadStream.Close();

						foreach (Group g in KeyChainManager.KeyChain.Groups)
						{
							groupTreeControl1.AddTreeNodefromFileLoad(g);
							statusStripGroupTotal(g);
						}

						statusStripControl1.StatusBarComboboxClear();
						KeyChainManager.KeyChain.IsModified = false;
						Text = fileName;

					}
				}
				else if (dr == DialogResult.No)
				{
					string[] f = (string[])e.Data.GetData(DataFormats.FileDrop);
					string fileName = f[0];

					KeyChainManager.newKeyChain();
					groupTreeControl1.resetView();
					keyListControl1.resetView();
					keyDetailControl1.resetView();

					DataContractSerializer dcs = new DataContractSerializer(typeof(KeyChain));
					byte[] ToRead = File.ReadAllBytes(fileName);
					byte[] decryptedArray = CryptoHelper.Decrypt(ToRead);
					MemoryStream memoryreadStream = new MemoryStream(decryptedArray);
					KeyChainManager.KeyChain = (KeyChain)dcs.ReadObject(memoryreadStream);
					memoryreadStream.Close();

					foreach (Group g in KeyChainManager.KeyChain.Groups)
					{
						groupTreeControl1.AddTreeNodefromFileLoad(g);
						statusStripGroupTotal(g);
					}

					statusStripControl1.StatusBarComboboxClear();
					KeyChainManager.KeyChain.IsModified = false;
					Text = fileName;
				}
			}
			else
			{
				string[] f = (string[])e.Data.GetData(DataFormats.FileDrop);
				string fileName = f[0];

				KeyChainManager.newKeyChain();
				groupTreeControl1.resetView();
				keyListControl1.resetView();
				keyDetailControl1.resetView();

				DataContractSerializer dcs = new DataContractSerializer(typeof(KeyChain));
				byte[] ToRead = File.ReadAllBytes(fileName);
				byte[] decryptedArray = CryptoHelper.Decrypt(ToRead);
				MemoryStream memoryreadStream = new MemoryStream(decryptedArray);
				KeyChainManager.KeyChain = (KeyChain)dcs.ReadObject(memoryreadStream);
				memoryreadStream.Close();

				foreach (Group g in KeyChainManager.KeyChain.Groups)
				{
					groupTreeControl1.AddTreeNodefromFileLoad(g);
					statusStripGroupTotal(g);
				}

				statusStripControl1.StatusBarComboboxClear();
				KeyChainManager.KeyChain.IsModified = false;
				Text = fileName;
			}
			 */ 

		}


		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] f = (string[])e.Data.GetData(DataFormats.FileDrop);
				foreach (string x in f)
				{
					if (Path.GetExtension(x) == ".kcf")
					{
						e.Effect = DragDropEffects.All;
						return;
					}
					else
					{
						e.Effect = DragDropEffects.None;
					}
				}
			}
		}
#endregion
			
		private void MainForm_Load(object sender, EventArgs e)
		{
       
			Application.Idle += OnIdle;

            string executable = Assembly.GetExecutingAssembly().Location;
            string pathname = Path.GetDirectoryName(executable);
            string FileName = Path.Combine(pathname, "MyUserPreferences.xml");
			if (File.Exists(FileName))
			{
				XmlTextReader GetPref = new XmlTextReader(FileName);
				XmlNodeType Ntype;
				while (GetPref.Read())
				{
					Ntype = GetPref.NodeType;
					if (Ntype == XmlNodeType.Element)
					{
						if (GetPref.Name == "Font")
						{
							GetPref.Read();
							FontSelected = GetPref.Value;
							GetPref.Read();
							GetPref.Read();
							FontSize = Convert.ToInt32(GetPref.Value);
							GetPref.Read();
							GetPref.Read();
							if (Convert.ToBoolean(GetPref.Value) == true)
							{

								ShowInTaskbar = false;

							}
						}

					}
				}
			}
			ContextManager.CheckKeys += statusStripKeysSelected;
			ContextManager.GroupSelected += statusStripGroupTotal;
			KeyPassTrayIcon.ShowBalloonTip(2000);

		}
	
		
		void OnIdle(object sender, EventArgs e)
		{
			FileSave.Enabled=FileSaveAs.Enabled = ToolStripSave.Enabled = KeyChainManager.isModified;
		}


		private void MenuEditOpening(object sender, EventArgs e)
		{
			EditEditGroup.Enabled = EditAddEntry.Enabled = EditDeleteGroup.Enabled = ContextManager.SelectedGroup != null;
			EditEditEntry.Enabled = EditDeleteEntry.Enabled = EditDuplicateEntry.Enabled = ContextManager.SingularKey != null;
			EditAddGroup.Enabled = FileClose.Enabled = FileCloseAll.Enabled = this.MdiChildren.Count()>0;
		}
		

		public void statusStripKeysSelected(int i, int j)
		{
			statusStripControl1.StatusBarSelectedKeys(i, j);
			
		}

		public void StatusStripComboBoxEvent(string action, string ObjectChanged,int KorG){
			statusStripControl1.StatusBarComboboxUpdate(action, ObjectChanged, KorG);
		}
			

		public void statusStripGroupTotal(Group g)
		{
			MDIChildForm x = (MDIChildForm)ActiveMdiChild;
			statusStripControl1.NumberOfGroups(x.kc.Groups.Count);
		}

		
		public void _OnExit(object sender, FormClosingEventArgs e)
		{
	
		}
		#endregion


		#region Print Methods
		public void PrintNow()
		{
			PrintDocument ToPrint = new PrintDocument();
			ToPrint.PrintPage += new PrintPageEventHandler(PrintPreviewConstructor);
			PrintDialog p = new PrintDialog();
			p.Document = ToPrint;
			if (p.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}
			else{
			ToPrint.Print();
			}
		}

		private void FilePrintPreview_Click(object sender, EventArgs e)
		{
			
			PrintDocument PD= new PrintDocument();

		
			PD.PrintPage += new PrintPageEventHandler(PrintPreviewConstructor);
            PrintPreviewDialog pp = new PrintPreviewDialog();
			pp.Document = PD;
			pp.WindowState = FormWindowState.Maximized;
			pp.ShowDialog();
		}

		private void PrintPreviewConstructor(object sender, PrintPageEventArgs e)
		{
			Pen p = new Pen(Color.Black);
			Brush fill = new SolidBrush(Color.LightGray);
			Brush groupfill= new SolidBrush(Color.LightSkyBlue);
			Brush groupBrush = new SolidBrush(Color.Black);
			Brush b = new SolidBrush(Color.Blue);
			Font font = new Font("arial", 12);
			Graphics PageDraw = e.Graphics;
			Rectangle BackgroundCell = new Rectangle();
			BackgroundCell.Height = 40;
			BackgroundCell.Width = 100;
			
			

			#region PrintDocumentHeader

			PageDraw.FillRectangle(fill, 100, 60, 100, 40);
			PageDraw.DrawRectangle(p, 100, 60, 100, 40);
			string x = "Group";
            PageDraw.DrawString(x, font, b, 130, 70);
			//string x = KeyChainManager.KeyChain.Groups[0].Name; 

			PageDraw.FillRectangle(fill, 200, 60, 100, 40);
			PageDraw.DrawRectangle(p, 200, 60, 100, 40);
			x = "Title";
			PageDraw.DrawString(x, font, b, 230, 70);

			PageDraw.FillRectangle(fill, 300, 60, 100, 40);
			PageDraw.DrawRectangle(p, 300, 60, 100, 40);
			x = "Username";
			PageDraw.DrawString(x, font, b, 310, 70);

			PageDraw.FillRectangle(fill, 400, 60, 100, 40);
			PageDraw.DrawRectangle(p, 400, 60, 100, 40);
			x = "Password";
			PageDraw.DrawString(x, font, b, 410, 70);
			
			PageDraw.FillRectangle(fill, 500, 60, 100, 40);
			PageDraw.DrawRectangle(p, 500, 60, 100, 40);
			x = "URL";
			PageDraw.DrawString(x, font, b, 530, 70);

			PageDraw.FillRectangle(fill, 600, 60, 100, 40);
			PageDraw.DrawRectangle(p, 600, 60, 100, 40);
			x = "Notes";
			PageDraw.DrawString(x, font, b, 630, 70);
			#endregion
			int xcoord=100;
			int ycoord=100;
			b = new SolidBrush(Color.Black);

			StringFormat truncate = new StringFormat();
			truncate.Trimming=StringTrimming.EllipsisCharacter;
			RectangleF cells = new RectangleF(xcoord, ycoord, 100, 20);
			
			foreach (Group g in KeyChainManager.KeyChain.Groups)
			{
				xcoord = 100;
				cells = new RectangleF(xcoord, ycoord, 100, 20);
				BackgroundCell.Location = new Point(xcoord, ycoord);
				
				PageDraw.FillRectangle(groupfill, BackgroundCell);
				if (g.TextColor != null)
				{
					groupBrush = new SolidBrush(Color.FromArgb(g.TextColor[0], g.TextColor[1], g.TextColor[2]));
				}
				else
				{
					groupBrush = new SolidBrush(Color.Black);
				}
				PageDraw.DrawString(g.Name, font, groupBrush, cells,truncate);
				PageDraw.DrawRectangle(p,BackgroundCell);
				//change this to Preference default later
		
				ycoord += 40;
				foreach (Key k in g.Keys)
				{
					xcoord = 200;
					cells = new RectangleF(xcoord, ycoord, 100, 20);
					BackgroundCell.Location = new Point(xcoord, ycoord);
					PageDraw.DrawRectangle(p, BackgroundCell);
					PageDraw.DrawString(k.Title, font, b, cells,truncate);
					xcoord += 100;
					cells = new RectangleF(xcoord, ycoord, 100, 20);
					BackgroundCell.Location = new Point(xcoord, ycoord);
					PageDraw.DrawRectangle(p, BackgroundCell);
					PageDraw.DrawString(k.Username,font,b,cells,truncate);
					xcoord += 100;
					cells = new RectangleF(xcoord, ycoord, 100, 20);
					BackgroundCell.Location = new Point(xcoord, ycoord);
					PageDraw.DrawRectangle(p, BackgroundCell);
					PageDraw.DrawString(k.Password, font, b, cells, truncate);
					xcoord += 100;
					cells = new RectangleF(xcoord, ycoord, 100, 20);
					BackgroundCell.Location = new Point(xcoord, ycoord);
					PageDraw.DrawRectangle(p, BackgroundCell);
					PageDraw.DrawString(k.URL, font, b, cells, truncate);
					xcoord += 100;
					cells = new RectangleF(xcoord, ycoord, 100, 20);
					BackgroundCell.Location = new Point(xcoord, ycoord);
					PageDraw.DrawRectangle(p, BackgroundCell);
					PageDraw.DrawString(k.Note, font, b, cells, truncate);
					ycoord += 40;
				}
				ycoord += 40;
			}

		}
		 
		#endregion

		#region Preferences
		
		private void ToolsOptions_Click(object sender, EventArgs e)
		{
            UserPreferencesForm Options = new UserPreferencesForm();
			Options.selectedF = FontSelected;
			Options.selectedS = FontSize;
			if (ShowInTaskbar == true)
			{
				Options.HideinTaskbar = false;
			}
			else
			{
				Options.HideinTaskbar = true;
			}

            if (Options.ShowDialog() == DialogResult.OK)
            {
				if (Options.HideinTaskbar==true)
				{
					this.ShowInTaskbar = false;
				}
				else
				{
					this.ShowInTaskbar = true;
				}

				FontSelected = Options.selectedF;
				FontSize = Options.selectedS;
                KeyChainManager.invokeSelectedFont(Options.selectedF, Options.selectedS);
                string executable = Assembly.GetExecutingAssembly().Location;
                string pathname = Path.GetDirectoryName(executable);
                string FileName = Path.Combine(pathname, "MyUserPreferences.xml");
                if (File.Exists(FileName))
                {
                    File.Delete(FileName);
                }
                
                XmlTextWriter PrefSave = new XmlTextWriter(FileName, Encoding.UTF8);
                using (PrefSave)
                {
                    PrefSave.Formatting = Formatting.Indented;
                   
                    PrefSave.WriteStartElement("Font");
                    PrefSave.WriteString(Options.selectedF);
                    PrefSave.WriteStartElement("FontSize");
                    PrefSave.WriteString(Options.selectedS.ToString());
					PrefSave.WriteStartElement("HiddeninTaskbar");
					PrefSave.WriteString(Options.HideinTaskbar.ToString());
                }
			}
		}
               

		#endregion 

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (KeyChainManager.isModified == true)
			{
				DialogResult dr = MessageBox.Show("Current document has unsaved changes. Save Changes? ", "My Keypass",
					MessageBoxButtons.YesNoCancel);
				if (dr == DialogResult.Cancel)
				{
					return;
				}
				else if (dr == DialogResult.Yes)
				{
					ToolStripSave_Click(sender, e);
					if (KeyChainManager.isModified == false)
					{
						Close();
					}
					else
					{
						return;
					}
				}
				else
				{
					Close();
				}
			}
			else
			{
				Close();
			}
		}

		private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Maximized;
		}

		private void _TrayIcon_DoubleClick(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Maximized;
		}

		private void EditDuplicateEntry_Click(object sender, EventArgs e)
		{
			MDIChildForm x = (MDIChildForm)ActiveMdiChild;
			x.KeyDuplicate();
		}

		private void FileClose_Click(object sender, EventArgs e)
		{
			ActiveMdiChild.Close();
		}

		private void FileCloseAll_Click(object sender, EventArgs e)
		{
			foreach (MDIChildForm m in MdiChildren)
			{
				m.Close();
			}
		}

		

		
		

		
                
 

            

           
         

		
		

	}
		 
}

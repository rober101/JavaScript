SQLiteConnection c=new SQLiteConnection("Data Source=C:||verifica.sbhbd,")
con.open();
 string connetionString;
   SqlConnection cnn;
   connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
   cnn = new SqlConnection(connetionString);
   cnn.Open();
   MessageBox.Show("Connection Open  !");
   cnn.Close();
   sqladapter=(Conbsulta);
   dataset datase=new dataset();
   datase.Fill(datase,"dataset");
   reporte.registreData(datase,"dataset");

   reporte.Load("C");
   reporte.Show();
Report reporte=new Report();
reporte.load()

repor.Desing();
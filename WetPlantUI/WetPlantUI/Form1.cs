using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;
namespace WetPlantUI
{
    public partial class Form1 : Form
    {
        // Comunicación de Serial
        private Serial serial = new Serial();
        // Iniciar un nuevo hilo
        private Thread thread;

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateData()
        {
            while (true)
            {
                //Thread.Sleep(500);
                // Iniciamos la data en un array de strings
                string[] fdata = {"","","","","",""};
                // obtenemos los ultimos datos enviados
                string data = serial.ReadData();
                int j = 0;


                // Bucle para separar los datos por espacios
                for(int i = 0; i < data.Length; i++)
                {
                    fdata[j] += data[i].ToString();
                    if (data[i].ToString() == " ")
                    {
                        ++j;
                    }
                }

                // Try Catch para una correcta sincronizacion
                try
                {
                    // Obtenemos la data de los sensores
                    lblLightning.Text = fdata[0];
                    lblHumidity.Text = fdata[1];
                    lblTemperature.Text = fdata[2];

                    //Obtenemos la data de los actuadores
                    int ventilador = Int32.Parse(fdata[3]);
                    int luz = Int32.Parse(fdata[4]);
                    int bomba = Int32.Parse(fdata[5]);
                    Thread.Sleep(500);
                }
                catch
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carga de la fuente
            PrivateFontCollection pfc = new PrivateFontCollection();
            PrivateFontCollection pfc1 = new PrivateFontCollection();
            pfc.AddFontFile(Environment.CurrentDirectory + "/Fonts/DigitalNumbers-Regular.ttf");
            pfc1.AddFontFile(Environment.CurrentDirectory + "/Fonts/DidactGothic-Regular.ttf");
            Font font = new Font(pfc.Families[0], 46);

            // Aplicar la fuente cargada
            lblTemperature.Font = font;
            lblHumidity.Font = font;
            lblLightning.Font = font;
            lblSpeed.Font = new Font(pfc.Families[0], 30);
            lblPort.Font = new Font(pfc1.Families[0], 46);

            // Configuracion del puerto
            serial.Config("COM4", 9600);
            serial.SetTimeout(500, 500);

            lblPort.Text = "Puerto: " + serial.GetPort();
            lblSpeed.Text = serial.GetBaudrate();
           
            if(serial.Open() == false)
            {
                // MSG BOX de error
                MessageBox.Show("Error al conectarse con el puerto serie!!", "Fatal_Error");

                Environment.Exit(1);
            }
            // Nuevo proceso
            thread = new Thread(new ThreadStart(UpdateData));
            thread.Start();
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cerrar el Proceso
            thread.Abort();
        }

    }
    public class Serial
    {
        SerialPort serialport;
        public Serial()
        {
            // Instacia de el puerto serial
            serialport = new SerialPort();
        }

        public void Config(string port, int baudrate)
        {
            // Baudrate and Port Config
            serialport.PortName = port;
            serialport.BaudRate = baudrate;

            // Default settings
            serialport.Parity = Parity.None;
            serialport.StopBits = StopBits.One;
            serialport.Handshake = Handshake.None;
        }

        public string GetPort()
        {
            return serialport.PortName;
        }

        public string GetBaudrate()
        {
            return serialport.BaudRate.ToString();
        }

        public bool Open()
        {
            try
            {
                // Intentar abrir el puerto serie
                serialport.Open();
            }
            catch(Exception e)
            {
                // Devuelve false si no salio bien
                return false;
            }
            // Devuelve true si se pudo abrir correctamente
            return true;
        }

        public void SetTimeout(int read, int write)
        {
            // Setear Timeouts
            serialport.ReadTimeout = read;
            serialport.WriteTimeout = write;
        }

        public void Close()
        {
            // Cerrar la conexión
            serialport.Close();
        }

        public string ReadData()
        {
            // Leer linea
            return serialport.ReadLine();
        }

        public void SendData(string data)
        {
            // Enviar data
            serialport.Write(data);
        }
    }
}

using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

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
                // Iniciamos la data en un array de strings
                string[] fdata = {"","",""};
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

                // Los actualizamos en el label
                lblLightning.Text = fdata[0].ToString();
                lblHumidity.Text = fdata[1].ToString();
                lblTemperature.Text = fdata[2].ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuracion del puerto
            serial.Config("COM4", 9600);
            serial.SetTimeout(500, 500);
            serial.Open();

            //lblPort.Text = "Puerto: " + serial.GetPort();

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

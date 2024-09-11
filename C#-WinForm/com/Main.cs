using System.Runtime.InteropServices;

namespace com
{
	public partial class Main : Form
	{
		private const string DllPath = @"Comlib.dll";

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Auto)]
		private static extern IntPtr InitializeCOM_Utf16();

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Auto)]
		private static extern IntPtr UninitializeCOM_Utf16();

		[DllImport(DllPath, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		private static extern IntPtr InitializeWMI_Utf16();

		[DllImport(DllPath, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		private static extern IntPtr UninitializeWMI_Utf16();

		public Main()
		{
			InitializeComponent();

			UpdateCOMStatus(false);
			UpdateWMIStatus(false);
		}

		private void btnInitializeCOM_Click(object sender, EventArgs e)
		{
			IntPtr resultPtr = InitializeCOM_Utf16();
			string result = Marshal.PtrToStringUni(resultPtr);
			bool success = result.Contains("successfully");
			lblCOMStatus.Text = success ? "COM Initialized Successfully" : $"COM Initialization Failed: {result}";
			UpdateCOMStatus(success);
		}

		private void btnUninitializeCOM_Click(object sender, EventArgs e)
		{
			IntPtr resultPtr = UninitializeCOM_Utf16();
			string result = Marshal.PtrToStringUni(resultPtr);
			bool success = result.Contains("successfully");
			lblCOMStatus.Text = success ? "COM Uninitialized Successfully" : $"COM Uninitialization Failed: {result}";
			UpdateCOMStatus(!success);
		}

		private void btnInitializeWMI_Click(object sender, EventArgs e)
		{
			IntPtr resultPtr = InitializeWMI_Utf16();
			string result = Marshal.PtrToStringUni(resultPtr);
			bool success = result.Contains("successfully");
			lblWMIStatus.Text = success ? "WMI Initialized Successfully" : $"WMI Initialization Failed: {result}";
			UpdateWMIStatus(success);
		}

		private void btnUninitializeWMI_Click(object sender, EventArgs e)
		{
			IntPtr resultPtr = UninitializeWMI_Utf16();
			string result = Marshal.PtrToStringUni(resultPtr);
			bool success = result.Contains("successfully");
			lblWMIStatus.Text = success ? "WMI Uninitialized Successfully" : $"WMI Uninitialization Failed: {result}";
			UpdateWMIStatus(!success);
		}

		private void UpdateCOMStatus(bool isInitialized)
		{
			pictureBoxCOM.BackColor = isInitialized ? System.Drawing.Color.Green : System.Drawing.Color.Red;
		}

		private void UpdateWMIStatus(bool isInitialized)
		{
			pictureBoxWMI.BackColor = isInitialized ? System.Drawing.Color.Green : System.Drawing.Color.Red;
		}

		private void pictureBoxCOM_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}

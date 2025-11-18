using Microsoft.Win32;
using System.Diagnostics;

namespace Remove_Atlas_Branding
{
    public partial class MainWindow : Form
    {
        private static string modelText = "", manufacturerText = "", supportPhoneText = "", supportURLText = "", organizationText = "";
        private static string themesPath = "C:\\Windows\\Resources\\Themes";
        private static string userAccountPicturesPath = "C:\\ProgramData\\Microsoft\\User Account Pictures";
        private static string defaultUserAccountPicturesPath = Environment.CurrentDirectory + "\\Default User Account Pictures";
        private static RegistryKey OEMInformation = Registry.LocalMachine.OpenSubKey("SOFTWARE")!
                                                                         .OpenSubKey("Microsoft")!
                                                                         .OpenSubKey("Windows")!
                                                                         .OpenSubKey("CurrentVersion")!
                                                                         .OpenSubKey("OEMInformation", true)!;
        private static RegistryKey RegisteredOrganizationKey = Registry.LocalMachine.OpenSubKey("SOFTWARE")!
                                                                                    .OpenSubKey("Microsoft")!
                                                                                    .OpenSubKey("Windows NT")!
                                                                                    .OpenSubKey("CurrentVersion", true)!;
        public MainWindow()
        {
            InitializeComponent();

            label1.Text = "Model: " + GetRegistry("Model");
            label2.Text = "Manufacturer: " + GetRegistry("Manufacturer");
            label3.Text = "SupportPhone: " + GetRegistry("SupportPhone");
            label4.Text = "SupportURL: " + GetRegistry("SupportURL");
            if (string.IsNullOrEmpty(RegisteredOrganizationKey.GetValue("RegisteredOrganization")!.ToString())) label5.Text = "Organization: No Value Found";
            else label5.Text = "Organization: " + RegisteredOrganizationKey.GetValue("RegisteredOrganization")!.ToString();
        }
        private void RemoveAll_Click(object sender, EventArgs e)
        {
            SetRegistry("Model", "");
            SetRegistry("Manufacturer", "");
            SetRegistry("SupportPhone", "");
            SetRegistry("SupportURL", "");
            RegisteredOrganizationKey.SetValue("RegisteredOrganization", "");

            label1.Text = "Model: " + "No Value Found";
            label2.Text = "Manufacturer: " + "No Value Found";
            label3.Text = "SupportPhone: " + "No Value Found";
            label4.Text = "SupportURL: " + "No Value Found";
            label5.Text = "Organization: " + "No Value Found";

            string[] themeFiles = Directory.GetFiles(themesPath, "atlas*.theme");
            foreach (var item in themeFiles) File.Delete(item);

            List<string> userAccountPictureFiles = Directory.GetFiles(userAccountPicturesPath, "*.png").ToList();
            userAccountPictureFiles.AddRange(Directory.GetFiles(userAccountPicturesPath, "*bmp").ToList());

            List<string> defaultUserAccountPictureFiles = Directory.GetFiles(defaultUserAccountPicturesPath, "*.png").ToList();
            defaultUserAccountPictureFiles.AddRange(Directory.GetFiles(defaultUserAccountPicturesPath, "*bmp").ToList());

            for (int i = 0; i < userAccountPictureFiles.Count; i++) File.Copy(defaultUserAccountPictureFiles[i], userAccountPictureFiles[i], true);

            if (RegisteredOrganizationKey.GetValue("RegisteredOrganization") != null) RegisteredOrganizationKey.SetValue("RegisteredOrganization", "");

            MessageBox.Show("Removed all branding", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ApplyChanges_Click(object sender, EventArgs e)
        {
            SetRegistry("Model", modelText);
            SetRegistry("Manufacturer", manufacturerText);
            SetRegistry("SupportPhone", supportPhoneText);
            SetRegistry("SupportURL", supportURLText);
            RegisteredOrganizationKey.SetValue("RegisteredOrganization", organizationText);

            label1.Text = "Model: " + GetRegistry("Model");
            label2.Text = "Manufacturer: " + GetRegistry("Manufacturer");
            label3.Text = "SupportPhone: " + GetRegistry("SupportPhone");
            label4.Text = "SupportURL: " + GetRegistry("SupportURL");
            if (string.IsNullOrEmpty(RegisteredOrganizationKey.GetValue("RegisteredOrganization")!.ToString())) label5.Text = "Organization: No Value Found";
            else label5.Text = "Organization: " + RegisteredOrganizationKey.GetValue("RegisteredOrganization")!.ToString();
        }
        private void OpenAboutSettings_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("ms-settings:about") { UseShellExecute = true });
        }
        private void Winver_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("winver") { UseShellExecute = true });
        }
        private void Model_TextChanged(object sender, EventArgs e)
        {
            modelText = (sender as TextBox)!.Text;
        }
        private void Manufacturer_TextChanged(object sender, EventArgs e)
        {
            manufacturerText = (sender as TextBox)!.Text;
        }
        private void SupportPhone_TextChanged(object sender, EventArgs e)
        {
            supportPhoneText = (sender as TextBox)!.Text;
        }
        private void SupportURL_TextChanged(object sender, EventArgs e)
        {
            supportURLText = (sender as TextBox)!.Text;
        }
        private void Organization_TextChanged(object sender, EventArgs e)
        {
            organizationText = (sender as TextBox)!.Text;
        }
        private static void SetRegistry(string key, string value)
        {
            OEMInformation.SetValue(key, value);
        }
        private static string GetRegistry(string key)
        {
            if (string.IsNullOrEmpty(OEMInformation.GetValue(key)!.ToString())) return "No Value Found";

            return OEMInformation.GetValue(key)!.ToString()!;
        }
    }
}
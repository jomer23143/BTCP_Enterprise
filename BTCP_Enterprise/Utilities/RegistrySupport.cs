/* ***************************************
 *			 ModifyRegistry.cs
 * ---------------------------------------
 *         a very simple class
 *    to read, write, delete and count
 *       registry values with C#
 * ---------------------------------------
 *      if you improve this code
 *   please email me your improvement!
 * ---------------------------------------
 *         by Francesco Natali
 *        - fn.varie@libero.it -
 * ***************************************/

using System;

// it's required for reading/writing into the registry:
using Microsoft.Win32;

// and for the MessageBox function:
using System.Windows.Forms;

namespace Utility.ModifyRegistry
{
    /// <summary>
    /// An useful class to read/write/delete/count registry keys
    /// </summary>
    public class RegistrySupport
    {
        private bool showError = false;

        /// <summary>
        /// A property to show or hide error messages
        /// (default = false)
        /// </summary>
        public bool ShowError
        {
            get { return showError; }
            set { showError = value; }
        }

        private string subKey = "SOFTWARE\\" + Application.ProductName.ToUpper();

        /// <summary>
        /// A property to set the SubKey value
        /// (default = "SOFTWARE\\" + Application.ProductName.ToUpper())
        /// </summary>
        public string SubKey
        {
            get { return subKey; }
            set { subKey = value; }
        }

        private RegistryKey baseRegistryKey = Registry.LocalMachine;

        /// <summary>
        /// A property to set the BaseRegistryKey value.
        /// (default = Registry.LocalMachine)
        /// </summary>
        public RegistryKey BaseRegistryKey
        {
            get { return baseRegistryKey; }
            set { baseRegistryKey = value; }
        }

        /* **************************************************************************
		 * **************************************************************************/

        /// <summary>
        /// To read a registry key.
        /// input: KeyName (string)
        /// output: value (string)
        /// </summary>
        public string Read(string KeyName)
        {
            // Opening the registry key
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(subKey);;
            // Open a subKey as read-only
            //RegistryKey sk1 = rk.OpenSubKey(subKey);
            // If the RegistrySubKey doesn't exist -> (null)
            if (rk == null)
            {
                return null;
            }
            else
            {
                try
                {
                    // If the RegistryKey exists I get its value
                    // or null is returned.
                    return (string)rk.GetValue(KeyName.ToUpper());
                }
                catch (Exception e)
                {
                    // AAAAAAAAAAARGH, an error!
                    ShowErrorMessage(e, "Reading registry " + KeyName.ToUpper());
                    return null;
                }
            }
        }

        /* **************************************************************************
		 * **************************************************************************/

        /// <summary>
        /// To write into a registry key.
        /// input: KeyName (string) , Value (object)
        /// output: true or false
        /// </summary>
        public bool Write(string KeyName, object Value)
        {
            try
            {
                // Setting
                RegistryKey rk = Registry.CurrentUser.CreateSubKey(subKey);
                // I have to use CreateSubKey
                // (create or open it if already exits),
                // 'cause OpenSubKey open a subKey as read-only
                //RegistryKey sk1 = rk.CreateSubKey(subKey);
                // Save the value
                rk.SetValue(KeyName.ToUpper(), Value);

                return true;
            }
            catch (Exception e)
            {
                // AAAAAAAAAAARGH, an error!
                showError = true;
                ShowErrorMessage(e, "Writing registry " + KeyName.ToUpper());
                showError = false;
                return false;
            }
        }

        /* **************************************************************************
		 * **************************************************************************/

        /// <summary>
        /// To delete a registry key.
        /// input: KeyName (string)
        /// output: true or false
        /// </summary>
        public bool DeleteKey(string KeyName)
        {
            try
            {
                // Setting
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.CreateSubKey(subKey);
                // If the RegistrySubKey doesn't exists -> (true)
                if (sk1 == null)
                    return true;
                else
                    sk1.DeleteValue(KeyName);

                return true;
            }
            catch (Exception e)
            {
                // AAAAAAAAAAARGH, an error!
                ShowErrorMessage(e, "Deleting SubKey " + subKey);
                return false;
            }
        }

        /* **************************************************************************
		 * **************************************************************************/

        /// <summary>
        /// To delete a sub key and any child.
        /// input: void
        /// output: true or false
        /// </summary>
        public bool DeleteSubKeyTree()
        {
            try
            {
                // Setting
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(subKey);
                // If the RegistryKey exists, I delete it
                if (sk1 != null)
                    rk.DeleteSubKeyTree(subKey);

                return true;
            }
            catch (Exception e)
            {
                // AAAAAAAAAAARGH, an error!
                ShowErrorMessage(e, "Deleting SubKey " + subKey);
                return false;
            }
        }

        /* **************************************************************************
		 * **************************************************************************/

        /// <summary>
        /// Retrive the count of subkeys at the current key.
        /// input: void
        /// output: number of subkeys
        /// </summary>
        public int SubKeyCount()
        {
            try
            {
                // Setting
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(subKey);
                // If the RegistryKey exists...
                if (sk1 != null)
                    return sk1.SubKeyCount;
                else
                    return 0;
            }
            catch (Exception e)
            {
                // AAAAAAAAAAARGH, an error!
                ShowErrorMessage(e, "Retriving subkeys of " + subKey);
                return 0;
            }
        }

        /* **************************************************************************
		 * **************************************************************************/

        /// <summary>
        /// Retrive the count of values in the key.
        /// input: void
        /// output: number of keys
        /// </summary>
        public int ValueCount()
        {
            try
            {
                // Setting
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(subKey);
                // If the RegistryKey exists...
                if (sk1 != null)
                    return sk1.ValueCount;
                else
                    return 0;
            }
            catch (Exception e)
            {
                // AAAAAAAAAAARGH, an error!
                ShowErrorMessage(e, "Retriving keys of " + subKey);
                return 0;
            }
        }

        /* **************************************************************************
		 * **************************************************************************/

        private void ShowErrorMessage(Exception e, string Title)
        {
            if (showError == true)
                MessageBox.Show(e.Message,
                                Title
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
        }
    }

    public class Settings
    {
        public const String PROGRAM_GRID_KEY = "programs_key101";
    }
}
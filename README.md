# Autorun-Silmaripedia-.NET-3
Autorun DVD program for launching Silmaripedia installation.

## How it looks?
<br>

### Animated menu:

<img src="http://oi68.tinypic.com/jg6sys.jpg">

<br>

## Functions:

<br>

- Install program: Silmaripedia requires .NET Framework 4 to work properly. Autorun program automaticaly checks user's version of OS. Windows 7 already comes with .NET Framework 4 but Windows XP and Windows Vista don't.

```
 private void install_Click(object sender, EventArgs e)
        {
            install.ForeColor = Color.Orange;

            if (Environment.OSVersion.Version.Major == 5)
            {
                if (Environment.OSVersion.Version.Minor == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Na tym komputerze zainstalowany jest system Windows XP. Do prawidłowego działania programu w tym systemie wymagany jest Microsoft .NET Framework 4. Czy chcesz go zainstalować teraz?", "Wykryto Windows XP!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string fullPath = @"DATA_bin\imp_fil\.net FRAMEWORK 4\dotNetFx40_Full_x86_x64.exe";
                        ProcessStartInfo psi = new ProcessStartInfo();
                        psi.FileName = Path.GetFileName(fullPath);
                        psi.WorkingDirectory = Path.GetDirectoryName(fullPath);                      
                        var process = Process.Start(psi);
                        process.WaitForExit();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        
                    }
                }
                else if (Environment.OSVersion.Version.Minor == 2)
                {
                    DialogResult dialogResult = MessageBox.Show("Na tym komputerze zainstalowany jest system Windows XP 64 bit lub Windows Server 2003. Do prawidłowego działania programu w tym systemie wymagany jest Microsoft .NET Framework 4. Czy chcesz go zainstalować teraz?", "Wykryto Windows XP 64 bit lub Server 2003!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string fullPath = @"DATA_bin\imp_fil\.net FRAMEWORK 4\dotNetFx40_Full_x86_x64.exe";
                        ProcessStartInfo psi = new ProcessStartInfo();
                        psi.FileName = Path.GetFileName(fullPath);
                        psi.WorkingDirectory = Path.GetDirectoryName(fullPath);
                        var process = Process.Start(psi);
                        process.WaitForExit();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
            }

            Process.Start(@"DATA_bin\install\setup.exe");
            sndpl.Play();
        }

```

- Open manual: Opens .txt file with instructions

- Silmaripedia home page: Site still in construction

- Extras: Wallpapers and ringtones made by me (just for fun)

- Exit program: Closes application

- Optimalization button (little square button in right bottom corner): Turns off animated background. Animated background looks nice but older computers may have problem with displaying it.

<img src="http://oi66.tinypic.com/6eq2qc.jpg">

```
Background after clicking the optimalization button
```

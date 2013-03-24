@ECHO OFF
CLS

REM This is an example script to show how to use the Help Library Manager
REM Launcher to install an MS Help Viewer file.  You can use this as an example
REM for creating a script to run from your product's installer.

REM NOTE: If not executed from within the same folder as the executable, a
REM full path is required on the executable and the HelpContentSetup.msha file.

REM Uninstall first in case it is already there.  If not, it won't install
REM below.  We'll ignore any error output by redirecting it to NUL.
HelpLibraryManagerLauncher.exe /product "VS" /version "100" /locale en-us /uninstall /silent /vendor "Vendor Name" /mediaBookList "ChildEducationSoftware" /productName "ChildEducationSoftware" > NUL

REM The setup name must be HelpContentSetup.msha so make sure we copy the
REM setup file to that name.  SHFB names it after the help file so that
REM multiple files can be deployed to the same output older at build time.
COPY /Y "ChildEducationSoftware.msha" HelpContentSetup.msha

REM Install the new content.
HelpLibraryManagerLauncher.exe /product "VS" /version "100" /locale en-us /brandingPackage Dev10.mshc /sourceMedia HelpContentSetup.msha

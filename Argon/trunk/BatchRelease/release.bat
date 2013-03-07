rem Release maker
echo
echo	Release %1
echo
7za a -tzip .\ArgonNetworkSwitcher-%1.zip ..\ArgonInstaller\Release\*.*
7za a -tzip .\ArgonNetworkSwitcher-debug-%1.zip ..\ArgonInstaller\Debug\*.*
svn export https://argon-network-switcher.googlecode.com/svn/Argon/tags/%1 .\export
cd .\export
..\7za a -tzip ..\ArgonNetworkSwitcher-%1-src.zip .
cd ..
rmdir /S /Q export
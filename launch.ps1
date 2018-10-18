$currentDir = (Get-Item -Path ".\").FullName;

& docker run -it -v "$currentDir\:/repo" -p 9000:9000 gitpitch/desktop:pro
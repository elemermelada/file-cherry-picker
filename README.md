# FileCherryPicker
 
Simple program to copy a list of files keeping the directory structure. Very useful to make a zip of the files that can not be sent via `ftp`, so they can be quickly sent and saved in the right location.

With filezilla, the workflow is as follows:
1. Export the `XML` file containing the files that could not be transfered
2. Convert the `XML` file to `JSON`
    1. Use an online tool to create the `JSON`
    1. Copy the `JSON` to a javascript variable named `data` and run `data.FileZilla3.Queue.Server.File.map(el=>el.LocalFile)`
3. Save the `JSON` in a file and copy its location to the `path` variable in `Form1.vb`
4. Change the `root` variable as desired (it will be the root inside the zip file)
5. Run the program

Step 2 can be replaced with whatever method to obtain a list of files in the `JSON` format is desired.

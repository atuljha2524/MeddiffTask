import os
def get_error_and_warning_messages(path_to_log_file):
    file = open(path_to_log_file, 'r')
    lines = file.read().splitlines()
    file.close()
    
    with open("myOutFile.txt", "w") as outF:
        outF.write("Errors")
        outF.write("\n")
        outF.write("===================================================================")
        outF.write("\n")
        for line in lines:
            if 'error' in line:
                #print("in error")
                outF.write(line)
                outF.write("\n")
        outF.write("\n")
        outF.write("\n")
        outF.write("Warnings")
        outF.write("\n")
        outF.write("===================================================================")
        outF.write("\n")
        for line in lines:
            if 'warning' in line:
                #print('in warning')
                outF.write(line)
                outF.write("\n")

    
    
os.chdir(".")
get_error_and_warning_messages("./sample.log")


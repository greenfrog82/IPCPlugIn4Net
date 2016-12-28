import PlugIn

plugIn = PlugIn.PlugIn()

cmd = input()

while ('q' != cmd):
    if 'pre' == cmd:
        #print('PreRun')
        plugIn.preRun('PreRun')
    elif 'run' == cmd:
        #print('Run')
        plugIn.run('Run')
    elif 'post' == cmd:
        #print('PostRun')
        plugIn.postRun('PostRun')
    cmd = input()
    

print('PythonStub has been finished by PlugInProxy.\n')

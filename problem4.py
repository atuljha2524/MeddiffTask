class Path:
    def __init__(self, current_path):
        self.current_path = current_path

    def cd(self, path):
        if path[0] == '/':
            self.current_path = path
        elif (path[0] >= 'a' and path[0] <= 'z') or (path[0] >= 'A' and path[0] <= 'Z'):
            if (self.current_path[-1] == '/'): 
                self.current_path = self.current_path + path
            elif (self.current_path[-1] != '/'):
                self.current_path = self.current_path + '/' + path 
        else :
            path_array = path.split('/')
            current_path_array = self.current_path.split('/')
            if (current_path_array[-1] == ''): 
                current_path_array.pop()
            for i in path_array:
                if i == '..':
                    current_path_array.pop()
                else :
                    current_path_array.append(i)
            self.current_path = '/'.join(current_path_array)

p = Path('/a/b')
p.cd('../../g')
print(p.current_path)
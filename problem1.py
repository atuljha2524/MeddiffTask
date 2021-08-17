def group_by_owner(file_to_owner_mapping):
    owner_to_files_mapping = {}
    for file, owner in file_to_owner_mapping.items():
        if owner not in owner_to_files_mapping:
            owner_to_files_mapping[owner] = []
        owner_to_files_mapping[owner].append(file)

    return owner_to_files_mapping

file_to_owner_mapping =  {'Input.txt': 'Randy', 'Code.py': 'Stan', 'Output.txt': 'Randy'} 
owner_to_files_mapping = group_by_owner(file_to_owner_mapping)
print(owner_to_files_mapping)
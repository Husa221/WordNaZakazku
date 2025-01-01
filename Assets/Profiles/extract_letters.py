from pathlib import Path

from unityparser import UnityDocument

about_me_set = set()
name_set = set()
directory = Path(".")
file_list = list(directory.glob('**/*.asset'))
print(file_list)

for file_path in file_list:
	if file_path.name == "Cthul.asset":
		pass
	print(file_path)
	parsed = UnityDocument.load_yaml(file_path)
	profile_name = parsed.entry.profileName
	print(profile_name)
	about_me = parsed.entry.aboutMe
	print(about_me)
	print(set(about_me))
	about_me_set.update(about_me)
	name_set.update(profile_name)
	print()

print(about_me_set)
print(len(about_me_set))

output = Path("output.txt")
out_string = "".join(list(about_me_set))
output.write_text(out_string, encoding="utf-8")

print(name_set)
print(len(name_set))

output = Path("output_names.txt")
out_string = "".join(list(name_set))
output.write_text(out_string, encoding="utf-8")
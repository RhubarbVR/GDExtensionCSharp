
var currentDir = Directory.GetCurrentDirectory();
var currentDirDepth = currentDir.Where(x => Path.DirectorySeparatorChar == x).Count();
var rootPath = currentDir;
for (var i = 0; i < currentDirDepth; i++) {
	rootPath = Path.GetFullPath(Path.Combine(rootPath, ".."));
	if (File.Exists(Path.Combine(rootPath, "GDExtensionCSharp.sln"))) {
		break;
	}
}

if (!File.Exists(Path.Combine(rootPath, "GDExtensionCSharp.sln"))) {
	throw new Exception("Root not found");
}
Directory.SetCurrentDirectory(rootPath);

var documentationPath = "../godot_changes/doc/classes/"; //set to null if no godot repository is avaible
var configName = "float_32";
var apiPath = "./BindingGenerator/dump/extension_api.json";
var dir = "./GDExtension/Generated";

//create or clean directory
if (Directory.Exists(dir)) {
	Directory.Delete(dir, true);
}
Directory.CreateDirectory(dir);

var api = Api.Create(apiPath);
var convert = new Convert(api, dir, documentationPath, configName);
convert.Emit();

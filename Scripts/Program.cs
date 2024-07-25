using System.Runtime.CompilerServices;

/*
namespace FMC.Development
{
    *
    public class OldStuff()
    {
        ModObjectConstructor modObjectConstructor = new();
        public void Start()
        {
            // Setup Form Elements
            iconSearchTextBox.TextChanged += LoadAllIconPictures;
            create_project_button.Click += (sender, e) =>
            {
                if (project_name_text_box.Text.Length < 5)
                {
                    MessageBox.Show("Bitte gebe einen Projektnamen an! (Mehr als 5 Zeichen)");
                    return;
                }

                GenerateModFolder(project_name_text_box.Text);
            };


            Console.WriteLine(Program.standardFactorioPath);
            var dirs = Directory.GetDirectories(Program.standardFactorioInstallationPath);

            foreach (var dir in dirs)
            {
                Console.WriteLine("Found: " + dir);
            }
        }
        public ModObject tempModObject = new();
        public static int modObjectsCount = 0;

        /// <summary>
        /// Bei aktivieren der Buttons für das erstellen der jeweiligen ModObjects wird direkt eine Root Node in TreeView erstellt.
        /// </summary>
        public void ActivateLeftSidebar()
        {
            string[] moddebleContent = ["item", "recipe", "technology", "entity", "tile"];
            foreach (var modObjectId in moddebleContent)
            {
                ModObjectType modObjectType = ModObjectType.NONE;
                Button button = new Button();
                button.Text = modObjectId;
                // OnButtonClickEvent Register
                button.Click += (sender, e) =>
                {
                    switch (modObjectId)
                    {
                        case "item":
                            modObjectType = ModObjectType.ITEM;
                            break;
                        case "recipe":
                            modObjectType = ModObjectType.RECIPE;
                            break;
                        case "technology":
                            modObjectType = ModObjectType.TECHNOLOGY;
                            break;
                        case "entity":
                            modObjectType = ModObjectType.ENTITY;
                            break;
                        case "tile":
                            modObjectType = ModObjectType.TILE;
                            break;
                    }


                    // Erstelle neues ModObject
                    ModObject modObject = modObjectConstructor.CreateModObject(modObjectType);
                    modObject = modObjectConstructor.SetNeededProperties(modObject);

                    TreeNode newSubNode = new();
                    newSubNode.Text = $"{modObjectId + modObjectsCount}";
                    newSubNode.Tag = modObject;

                    TreeNode rootNode = GetRootNode(modObjectId);
                    rootNode.Nodes.Add(newSubNode);
                };
                CreateRootNode(modObjectId);
                mod_objects_flow_panel.Controls.Add(button);

            }
            LoadAllIconPictures(this, EventArgs.Empty);
        }
        struct TreeViewRootNodeDisplayNames
        {
            public string id;
            public string displayName;
        }

        TreeViewRootNodeDisplayNames[] rootNodeDisplayNames =
        {
            new()
            {
                id = "item",
                displayName = "Items"
            },
            new()
            {
                id = "recipe",
                displayName = "Rezepte"
            },
            new()
            {
                id = "technology",
                displayName = "Technologien"
            },
            new()
            {
                id = "entity",
                displayName = "Entities"
            },
            new()
            {
                id = "tile",
                displayName = "Kachel"
            }
        };

        string GetModObjectDisplayName(string id)
        {
            foreach (TreeViewRootNodeDisplayNames obj in rootNodeDisplayNames)
            {
                if (obj.id == id)
                {
                    return obj.displayName;
                }
            }
            return "404"; // because cool und so :)
        }
        /// <summary>
        /// Versucht die Hauptnode zu erstellen
        /// </summary>
        /// <param name="modObjectId"></param>
        /// <param name="modObjectType"></param>
        /// <returns>Gibt zurück ob eine Hauptnode erstellt wurde oder nicht.</returns>
        bool CreateRootNode(string modObjectId) // modObjectId => item, recipe, technology...
        {
            var displayName = GetModObjectDisplayName(modObjectId);
            if (!TreeViewHasRootNode(modObjectId))
            {
                TreeNode treeNode = new();
                treeNode.Text = displayName;
                mod_objects_tree_view.Nodes.Add(treeNode);
                return true;
            }
            return false;
        }

        bool TreeViewHasRootNode(string modObjectId)
        {
            var nodes = mod_objects_tree_view.Nodes;
            foreach (TreeNode node in nodes)
            {
                if (node.Text == GetModObjectDisplayName(modObjectId))
                {
                    return true;
                }
            }
            return false;
        }

        TreeNode GetRootNode(string modObjectId)
        {
            var nodes = mod_objects_tree_view.Nodes;
            var displayName = GetModObjectDisplayName(modObjectId);
            foreach (TreeNode node in nodes)
            {
                if (node.Text == displayName)
                {
                    return node;
                }
            }
            return null;
        }
        public void DeactivateLeftSidebar()
        {
            mod_objects_flow_panel.Controls.Clear();
        }

        public void LoadAllIconPictures(object sender, EventArgs e)
        {
            var pngs = Directory.GetFiles(Program.iconPath);

            item_icons_flow_panel.Controls.Clear();

            iconProgressBar.Maximum = pngs.Length;
            iconProgressBar.Value = 0;
            iconProgressBar.Visible = true;

            foreach (var png in pngs)
            {
                iconProgressBar.Value++;

                var filename = Path.GetFileName(png).Replace(".png", string.Empty);
                using var stream = new FileStream(png, FileMode.Open, FileAccess.Read);

                PictureBox newIconPictureBox = new PictureBox();
                Label label = new Label();
                label.Text = filename;
                label.Font = new Font(label.Font.FontFamily, 6);

                newIconPictureBox.Image = Image.FromStream(stream);
                newIconPictureBox.Size = new(65, 65);
                newIconPictureBox.Tag = filename;
                newIconPictureBox.MouseEnter += IconPictureMouseHover;

                if (filename.Contains(iconSearchTextBox.Text))
                {
                    item_icons_flow_panel.Controls.Add(newIconPictureBox);
                    item_icons_flow_panel.Controls.Add(label);
                }

                Console.WriteLine($"Lade Bild: {png}");
            }
            iconProgressBar.Visible = false;
        }
        public void GenerateModFolder(string modName)
        {
            int directoryCount = Directory.GetDirectories(Path.Combine(Program.standardProgramPath, "output")).Length;
            var outputPath = Path.Combine(Program.standardProgramPath, "output", (modName + "_" + directoryCount.ToString()));
            if (Directory.Exists(outputPath))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(outputPath);
                Console.BackgroundColor = ConsoleColor.Black;

            }
            // Projekt kann erstellt werden
            Directory.CreateDirectory(outputPath);
            Console.WriteLine("Projekt wurde erstellt.");
            MessageBox.Show("Projekt wurde erfolgreich erstellt.\nDu befindest dich nun im Edit-Mode");
            ActivateLeftSidebar();
            create_project_button.Enabled = false;
            EventManager eventManager = new();
            eventManager.InvokeEventByName("OnProjectCreate");
        }
        public void IconPictureMouseHover(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                Console.WriteLine("Selected: " + pictureBox.Tag);
            }
        }

        public void VisualizeModObject(ModObject modObject)
        {

        }
    }
}
*/
namespace FMC.Scripts
{
    internal static class Program
    {

        public static MainWindow? mainForm;

        public static string standardFactorioPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Factorio");
        public static string standardFactorioInstallationPath = "E:\\SteamLibrary\\steamapps\\common\\Factorio\\data\\base";

        public static string standardProgramPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FMC");

        public static string iconPath = "E:\\SteamLibrary\\steamapps\\common\\Factorio\\data\\base\\graphics\\icons";

        public static string modName = string.Empty;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitProgramFolders();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // mainForm = new MainWindow();
            // Application.Run(mainForm);


            InitProgramFolders();
            FileStreamer.Read();

        }

        static void InitProgramFolders()
        {
            if (!Directory.Exists(standardProgramPath))
            {
                Directory.CreateDirectory(standardProgramPath);
            }
            string[] subfolders = ["output"];
            foreach (string folder in subfolders)
            {
                var subPath = Path.Combine(standardProgramPath, folder);
                if (!Directory.Exists(subPath))
                {
                    Directory.CreateDirectory(subPath);
                }
            }
        }


    }
}
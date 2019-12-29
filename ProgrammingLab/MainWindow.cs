using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginSystemLib;

namespace ProgrammingLab
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            Console.WriteLine("MainWindow loading started...");

            var pluginsList = LoadPlugins();

            Console.WriteLine("Returned to MainWindow user interface generation...");

            Console.WriteLine("Plugins list UI generation started!");

            foreach (var plugin in pluginsList)
            {

                Console.WriteLine("Current plugin: " + plugin.GetType().FullName + " at " + plugin.GetHashCode() + " in " + plugin.GetType().Assembly.FullName);

                Console.WriteLine(plugin.GetHashCode() + ": Plugin button generation started: ");

                var btn = new Button
                {
                    AutoEllipsis = true,
                    BackColor = Color.White,
                    Dock = DockStyle.Top,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(0, 0),
                    Size = new Size(534, 30),
                    TextAlign = ContentAlignment.MiddleLeft,
                    UseVisualStyleBackColor = false
                };

                btn.FlatAppearance.BorderSize = 0;

                btn.Text = plugin.GetPluginName();

                Console.WriteLine(plugin.GetHashCode() + ": Adding event handlers...");

                btn.Click += delegate(object o, EventArgs args)
                {

                    Console.WriteLine("Type " + o.GetType().FullName + " at " + o.GetType().Assembly.FullName + " selected by user");
                    Console.WriteLine("Initializing new task thread");

                    var task = new Task(() =>
                    {

                        Console.WriteLine("Task started! Executing primary plugin action!");

                        plugin.ExecutePlugin();

                        Console.WriteLine("Plugin action execution process successfully finished!");
                        Console.WriteLine("Terminating task thread!");

                    });

                    Console.WriteLine("Task " + task.GetHashCode() + " created!");
                    Console.WriteLine("Starting task " + task.GetHashCode() + "...");

                    task.Start();

                    Console.WriteLine("Event handler for " + btn.GetHashCode() + " button terminating!");

                };

                Console.WriteLine(plugin.GetHashCode() + ": Event handlers initialized successfully!");

                Console.WriteLine("Adding button to storage panel controls collection...");

                primaryPanel.Controls.Add(btn);

                Console.WriteLine("Successfully added!");

                Console.WriteLine("Updating storage panel...");

                primaryPanel.Update();

                Console.WriteLine("Storage panel successfully updated!");

                Console.WriteLine("DANGER: Updating MainWindow UI!");

                Update();
                UpdateBounds();
                UpdateStyles();

                Console.WriteLine("DANGEROUS PART SUCCESS: MainWindow update succeed!");

            }

            Console.WriteLine("Plugins list UI generation finished!");

            Console.WriteLine("MainWindow loading finished!");

            Console.WriteLine("Terminating MainWindow load scenario method!");

            Console.WriteLine("The program is in IDLE state.");

            List<PluginBase> LoadPlugins()
            {

                Console.WriteLine("Executing LoadPlugins()");

                var previewPluginList = (
                    from plugin in Directory.GetFiles(Directory.GetCurrentDirectory(), "Lab*.dll") // foreach
                    
                    select Assembly.LoadFile(plugin) into assembly // load file into assembly
                    
                    select assembly.GetTypes().First(
                        a => a.BaseType == typeof(PluginBase)
                    ) into objectType // select first found type with specified base
                    where objectType.IsSubclassOf(typeof(PluginBase)) // additional check

                    select (PluginBase) Activator.CreateInstance(objectType)
                ).ToList();

                Console.WriteLine("LoadPlugins() execution finished!");

                return previewPluginList;

            }

        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            _ = new AboutWnd().ShowDialog(this);
        }

    }
}
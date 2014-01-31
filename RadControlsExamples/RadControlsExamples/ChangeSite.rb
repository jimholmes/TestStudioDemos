require 'watir'
require 'optparse'
require 'fileutils'


def copy_start_files
	FileUtils.rm %w(Default.aspx Contacts.cs), :force => true
	FileUtils.cp("Contacts-Start.cs", "Contacts.cs")
	FileUtils.cp("Default-Start.aspx", "Default.aspx")
end

def copy_end_files
	FileUtils.rm %w(Default.aspx Contacts.cs), :force => true
	FileUtils.cp( "Contacts-End.cs", "Contacts.cs")
	FileUtils.cp( "Default-End.aspx", "Default.aspx")
end

def build_it
	system("C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\msbuild.exe RadControlsExamples.csproj")
end

def parse_opts
	$options = {}
	opts = OptionParser.new
	opts.banner = "Usage: ChangeSite [options]"

	opts.on("-s", "--start", "Set site to START") do
		$options[:start] = true
	end

	opts.on("-e", "--end", "Set site to END") do
		$options[:end] = true
	end

	opts.on("-h", "--help", "Display this screen") do
		puts opts
		exit
	end

	opts.parse(ARGV)	
	
	if ($options[:start].nil? && $options[:end].nil?)
		puts "Missing options"
		puts opts
		exit
	end
end

def launch_site
	$browser = Watir::Browser.start "http://localhost/WorkingWithLocators"
end

def do_the_work
	if $options[:start]
		copy_start_files()
	end

	if $options[:end]
		copy_end_files()
	end

	build_it()
	launch_site()
end

parse_opts()
do_the_work()

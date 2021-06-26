using System;

namespace Game{
	
	public class logging{
		
		public const string DefaultLocation = @"C:\Users\shawn\source\repos\MadLib 1\logs\";
		
		private string LogLocation;
		
		
		public logging(string path=""){
			if(string.isNullorEmpty(path)){
				LogLocation = DefaultLocation;
			}
			
			public bool WriteLog(string, title, string story_to_Write){
				using(FileStream fs = File.Create(LogLocation + title +@".txt"){
					byte[] info = new UTF8Encoding(true).GetBytes(story_to_Write);
					// Add some information to the file.
					fs.Write(info, 0, info.Length);
				}
				};
				
			}
		}
	}
}
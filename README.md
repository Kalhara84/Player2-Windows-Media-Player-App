# 🎵 Player2 — Windows Media Player App

**Player2** is a lightweight, Windows desktop media player built using **C# (.NET Framework)** and **Windows Media Player SDK**.  
It provides simple and efficient playback for video and audio files through an intuitive Windows Forms interface.

---

## ✨ Features

- ▶️ Play, pause, and stop media playback  
- 🎚️ Adjust and mute volume  
- ⏩ Seek and control playback position  
- 📂 Load and play local video or audio files  
- 💽 Supports most media formats (MP4, MP3, WMV, AVI, etc.)  
- 🪟 Modern, simple interface built in Windows Forms  

---

## 🧰 Technologies Used

- **Language:** C# (.NET Framework 4.0+)  
- **IDE:** Microsoft Visual Studio 2015+  
- **Libraries / Components:**  
  - `AxInterop.WMPLib.dll` — ActiveX interop for Windows Media Player  
  - `Interop.WMPLib.dll` — COM library for media player control  

---

## 🗂️ Project Structure

```
Player2/
├── Player2.sln                          # Visual Studio solution file
├── Player2/
│   ├── App.config                       # Application configuration
│   ├── Program.cs                       # Entry point
│   ├── Form1.cs                         # Main UI and logic
│   ├── Form1.Designer.cs                # UI layout definitions
│   ├── Form1.resx                       # Form resources
│   ├── Properties/
│   │   ├── AssemblyInfo.cs
│   │   ├── Resources.Designer.cs
│   │   ├── Resources.resx
│   │   ├── Settings.Designer.cs
│   │   └── Settings.settings
│   ├── bin/Debug/
│   │   ├── Player2.exe
│   │   ├── AxInterop.WMPLib.dll
│   │   └── Interop.WMPLib.dll
│   └── obj/                             # Build files
└── .vs/                                 # Visual Studio environment files
```

---

## ▶️ How to Run

1. **Open the project** in **Visual Studio**  
   ```
   Player2.sln
   ```

2. **Build the project:**  
   - Press **Ctrl + Shift + B** or select **Build → Build Solution**

3. **Run the application:**  
   - Press **F5** or select **Debug → Start Debugging**

4. **Load a media file** via the “Open” option or file dialog in the app.

---

## 🧩 Main Components

| File | Description |
|------|--------------|
| `Program.cs` | Entry point of the application |
| `Form1.cs` | Core playback logic |
| `Form1.Designer.cs` | Form UI layout |
| `AxInterop.WMPLib.dll` | ActiveX Windows Media Player integration |
| `Interop.WMPLib.dll` | COM interop support for playback control |

---

## 💡 Future Enhancements

- 🎞️ Add playlist management  
- 🎵 Support drag-and-drop for media files  
- 🧩 Add playback speed control  
- 🌙 Implement dark/light theme options  

---

## 🧠 Notes

- Requires **Windows Media Player** installed on the system.  
- Designed exclusively for **Windows OS**.  
- Ideal for educational projects or basic media applications.

---

## 📄 License

 [License](./LICENSE.md): Proprietary – Permission Required
---


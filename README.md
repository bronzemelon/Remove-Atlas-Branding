# Remove-Atlas-Branding

Removes branding after installing AtlasOS

## Instructions

```Model``` modifies the model name

```Manufacturer``` modifies the manufacturer name

```Support Phone``` modifies the support phone number

```Support URL``` modifies the hyperlink that redirects you when you click ```Online Support```

```Organization``` modifies the organization name that shows up under the hostname in winver product licensing

```Remove All``` removes all branding from various registry locations and windows folders

```Apply Changes``` applies any changes made from ```Model```, ```manufacturer```,```Support Phone```,```Support URL```,```Organization```

```Open About Settings``` opens about page in the settings

```Open Winver``` opens winver

## Locations
```Model, Manufacturer, Support Phone and Support URL: HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation```

```Organization: HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion```

```Themes: C:\Windows\Resources\Themes```

```User Account Pictures: C:\ProgramData\Microsoft\User Account Pictures```
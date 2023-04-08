# Template

This is a template if you are lazy just like me.
This just implements MAUI & Blazor as a template.

Template.Core

    -> Pages / Services / Shared, those are shared between the .Natives and .Web project.
    
    tldr; If you want anything to be on NATIVES and WEB this is the place to add it.

Template.Natives (for windows app, phones and macs)

    -> Is dependent on .Core
    
    -> Can have separeate Pages / Services than .Core or .Web

Template.Web (as a web app)

    -> Is dependent on .Core
    
    -> Can have separeate Pages / Services than .Core or .Natives

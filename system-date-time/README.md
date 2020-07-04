## 1) Adds record to registry in order to run the application at windows startup "RegisterApplication()"
## 2) Checks internet connection.
## 3) If computer is connected to internet than gets date and time from "time.nist.gov"
## 4) Updates System date and time with System.Diagnostics -> run cmd /C date /C time  "setTime() and setDate()"

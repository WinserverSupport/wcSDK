File   : Readme-Wildcat-Headers.txt
Date   : 08/19/25 05:14 pm
Version: v10.0.500.1

- Obsolete/Deprecated headers

   door32.h          deprepated, see wcdoor32.h
   build.h           deprepated, see wcbuild.h

- Helper Headers for Win32/64

   wcWinBuild.h
   wcCompiler.h

- WCSDK Standard Headers for basic WCSDK clients

   wctype.h           Wildcat! Server data structures
   wcserver.h         Wildcat! Server API functions
   wcserror.h         possible wcserver API errors
   wclinker.h         defines the 32/64 bit lib file to link
   wcbuild.h          see build.h
   wcglobal.h         defines Wildcat! version numbers constant
   wcverson.h         defines Wildcat! model versions

- WCSDK Standard Headers for "Mail Gateway" clients

   wcgtype.h
   wcsgate.h

- WCSDK Standard Headers for "Configuration" clients

   wcsmw.h
   wctypemw.h

- WCSDK Standard Headers for plug-in clients

   wcdoor32.h         for creating WCDOOR32 applications
   wcfront.h          for creating WCFRONTEND applications (i.e., PX/WIN) (see note #1)

- WCSDK Standard Headers for plug-in wcOnline hosting

   WconlineModule.h
   WildcatModuleProtocol.h

- This are not necessarily part of the WCSDK. They are helpers for
- some of the C/C++ examples.

   critsect.h  (see note #1)
   linestat.h  (see note #1)
   thread.h    (see note #1)


NOTES:

 1 -  found in "wcsdk\wcserver\cpp\include" folder only.


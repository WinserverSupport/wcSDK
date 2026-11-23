File   : Readme-Wildcat-Headers.txt
Date   : 11/23/26 08:51 am
Version: v10.0.500.4

- Obsolete/Deprecated headers

   door32.h          deprecated, see wcdoor32.h
   build.h           deprecated, see wcbuild.h

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
   wcversion.h        defines Wildcat! model versions

- WCSDK Standard Headers for "Mail Gateway" clients

   wcgtype.h
   wcsgate.h
   wcsgate_lib.h      auto-links wcsgate.lib / wcsgate64.lib

- WCSDK Standard Headers for "Configuration" clients

   wcsmw.h
   wctypemw.h
   wcsmw_lib.h        auto-links wcsmw.lib / wcsmw64.lib

- WCSDK Standard Headers for plug-in clients

   wcdoor32.h         for creating WCDOOR32 applications
   wcfront.h          for creating WCFRONTEND applications (i.e., PX/WIN) (see note #1)
   wcllib.h           wildcat.wcl code library format (wcx programs)

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


# Makefile for wcZork

!IF "$(CFG)" == ""
CFG=wcZork - Win32 Release
!MESSAGE No configuration specified. Defaulting to wcZork - Win32 Release.
!ENDIF

!IF "$(CFG)" != "wcZork - Win32 Release" && "$(CFG)" != "wcZork - Win32 Debug"
!MESSAGE Invalid configuration "$(CFG)" specified.
!MESSAGE You can specify a configuration when running NMAKE
!MESSAGE by defining the macro CFG on the command line. For example:
!MESSAGE
!MESSAGE NMAKE /f "wcZork.mak" CFG="wcZork - Win32 Release"
!MESSAGE
!MESSAGE Possible choices for configuration are:
!MESSAGE
!MESSAGE "wcZork - Win32 Release" (based on "Win32 (x86) Dynamic-Link Library")
!MESSAGE "wcZork - Win32 Debug" (based on "Win32 (x86) Dynamic-Link Library")
!MESSAGE
!ERROR An invalid configuration is specified.
!ENDIF

!IF "$(OS)" == "Windows_NT"
NULL=
!ELSE
NULL=nul
!ENDIF

!IF  "$(CFG)" == "wcZork - Win32 Release"

# Updated compiler flags for Windows SDK compatibility
CFLAGS = /D_CRT_SECURE_NO_WARNINGS /DWIN32 /D_NATIVE_WCHAR_T_DEFINED /D_WIN32_WINNT=0x0601 /Zc:wchar_t- /D_CRT_SECURE_NO_DEPRECATE /DNOMINMAX /wd4133 /wd4391 /wd4392 /wd4005 /wd4047 /wd4033 /TC /W3

# Where to install the program
BINDIR = .\usr\games

# Where to install the data file
DATADIR = .\usr\games\lib

# Where to install the man page
MANDIR = .\usr\share\man

OUTDIR=.\release
INTDIR=.\release

# Use Wildcat! Door32 libraries
#LIBS = User32.lib

# The dungeon program provides a ``more'' facility which tries to
# figure out how many rows the terminal has.  Several mechanisms are
# supported for determining this; the most common one has been left
# uncommented.  If you have trouble, especially when linking, you may
# have to select a different option.

# more option 1: use the termcap routines.  On some systems the LIBS
# variable may need to be set to -lcurses.  On some it may need to
# be /usr/lib/termcap.obj.  These options are commented out below.
# LIBS = -ltermcap
# TERMFLAG =
# LIBS = -lcurses
# LIBS = /usr/lib/termcap.obj

# more option 2: use the terminfo routines.  On some systems the LIBS
# variable needs to be -lcursesX, but probably all such systems support
# the termcap routines (option 1) anyhow.
# LIBS = -lcurses
# TERMFLAG = -DMORE_TERMINFO

# more option 3: assume all terminals have 24 rows
# LIBS =
# TERMFLAG = -DMORE_24

# more option 4: don't use the more facility at all
LIBS = User32.lib wcdoor32.lib
TERMFLAG = -DMORE_NONE

# End of more options

# Uncomment the following line if you want to have access to the game
# debugging tool.  This is invoked by typing "gdt".  It is not much
# use except for debugging.
# GDTFLAG = -DALLOW_GDT

# Compilation flags
# CFLAGS = -g #-static
CFLAGS =
# On SCO Unix Development System 3.2.2a, the const type qualifier does
# not work correctly when using cc.  The following line will cause it
# to not be used and should be uncommented.
# CFLAGS= -O -Dconst=

##################################################################

# Source files
CSRC =	actors.c ballop.c clockr.c demons.c dgame.c dinit.c dmain.c\
	dso1.c dso2.c dso3.c dso4.c dso5.c dso6.c dso7.c dsub.c dverb1.c\
	dverb2.c gdt.c lightp.c local.c nobjs.c np.c np1.c np2.c np3.c\
	nrooms.c objcts.c rooms.c sobjs.c supp.c sverbs.c verbs.c villns.c \
	wcio.c


OBJS =	$(INTDIR)\actors.obj $(INTDIR)\ballop.obj $(INTDIR)\clockr.obj $(INTDIR)\demons.obj $(INTDIR)\dgame.obj $(INTDIR)\dinit.obj $(INTDIR)\dmain.obj \
	$(INTDIR)\dso1.obj $(INTDIR)\dso2.obj $(INTDIR)\dso3.obj $(INTDIR)\dso4.obj $(INTDIR)\dso5.obj $(INTDIR)\dso6.obj $(INTDIR)\dso7.obj $(INTDIR)\dsub.obj $(INTDIR)\dverb1.obj \
	$(INTDIR)\dverb2.obj $(INTDIR)\gdt.obj $(INTDIR)\lightp.obj $(INTDIR)\local.obj $(INTDIR)\nobjs.obj $(INTDIR)\np.obj $(INTDIR)\np1.obj $(INTDIR)\np2.obj $(INTDIR)\np3.obj \
	$(INTDIR)\nrooms.obj $(INTDIR)\objcts.obj $(INTDIR)\rooms.obj $(INTDIR)\sobjs.obj $(INTDIR)\supp.obj $(INTDIR)\sverbs.obj $(INTDIR)\verbs.obj $(INTDIR)\villns.obj \
    $(INTDIR)\wcio.obj

wcZork.exe: $(OBJS)
   $(CC) $(CFLAGS) /FewcZork.exe $(OBJS) $(LIBS)

"$(OUTDIR)" :
   if not exist "$(OUTDIR)\$(NULL)" mkdir "$(OUTDIR)"

dungeon: $(OBJS) dtextc.dat
	$(CC) $(CFLAGS) /FewcZork.exe $(OBJS) $(LIBS)

install: wcZork dtextc.dat
	ECHO DEBUG: mkdir -p $(BINDIR) $(LIBDIR) $(MANDIR)/man6
	ECHO DEBUG: cp wcZork $(BINDIR)
	ECHO DEBUG: cp dtextc.dat $(DATADIR)
	ECHO DEBUG: cp dungeon.6 $(MANDIR)/man6/

clean:
	erase $(OBJS) wcZork.exe

dtextc.dat:
	ECHO DEBUG: cat dtextc.uu1 dtextc.uu2 dtextc.uu3 dtextc.uu4 | uudecode

$(INTDIR)\dinit.obj: dinit.c funcs.h vars.h
	$(CC) $(CFLAGS) $(GDTFLAG) -DTEXTFILE=\"$(DATADIR)/dtextc.dat\" -c dinit.c /Fo$(INTDIR)\dinit.obj

$(INTDIR)\dgame.obj: dgame.c funcs.h vars.h
	$(CC) $(CFLAGS) $(GDTFLAG) -c dgame.c  /Fo$(INTDIR)\dgame.obj

$(INTDIR)\gdt.obj: gdt.c funcs.h vars.h
	$(CC) $(CFLAGS) $(GDTFLAG) -c gdt.c    /Fo$(INTDIR)\gdt.obj

$(INTDIR)\local.obj: local.c funcs.h vars.h
	$(CC) $(CFLAGS) $(GDTFLAG) -c local.c  /Fo$(INTDIR)\local.obj

$(INTDIR)\supp.obj: supp.c funcs.h vars.h
	$(CC) $(CFLAGS) $(TERMFLAG) -c supp.c  /Fo$(INTDIR)\supp.obj

$(INTDIR)\actors.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c actors.c /Fo$(INTDIR)\actors.obj
$(INTDIR)\ballop.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c ballop.c /Fo$(INTDIR)\ballop.obj
$(INTDIR)\clockr.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c clockr.c /Fo$(INTDIR)\clockr.obj
$(INTDIR)\demons.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c demons.c /Fo$(INTDIR)\demons.obj
$(INTDIR)\dmain.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c dmain.c /Fo$(INTDIR)\dmain.obj
$(INTDIR)\dso1.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c dso1.c /Fo$(INTDIR)\dso1.obj
$(INTDIR)\dso2.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c dso2.c /Fo$(INTDIR)\dso2.obj
$(INTDIR)\dso3.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c dso3.c /Fo$(INTDIR)\dso3.obj
$(INTDIR)\dso4.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c dso4.c /Fo$(INTDIR)\dso4.obj
$(INTDIR)\dso5.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c dso5.c /Fo$(INTDIR)\dso5.obj
$(INTDIR)\dso6.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c dso6.c /Fo$(INTDIR)\dso6.obj
$(INTDIR)\dso7.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c dso7.c /Fo$(INTDIR)\dso7.obj
$(INTDIR)\dsub.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c dsub.c /Fo$(INTDIR)\dsub.obj
$(INTDIR)\dverb1.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c dverb1.c /Fo$(INTDIR)\dverb1.obj
$(INTDIR)\dverb2.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c dverb2.c /Fo$(INTDIR)\dverb2.obj
$(INTDIR)\lightp.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c lightp.c /Fo$(INTDIR)\lightp.obj
$(INTDIR)\nobjs.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c nobjs.c /Fo$(INTDIR)\nobjs.obj
$(INTDIR)\np.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c np.c /Fo$(INTDIR)\np.obj
$(INTDIR)\np1.obj: funcs.h vars.h parse.h
    $(CC) $(CFLAGS) -c np1.c /Fo$(INTDIR)\np1.obj
$(INTDIR)\np2.obj: funcs.h vars.h parse.h
    $(CC) $(CFLAGS) -c np2.c /Fo$(INTDIR)\np2.obj
$(INTDIR)\np3.obj: funcs.h vars.h parse.h
    $(CC) $(CFLAGS) -c np3.c /Fo$(INTDIR)\np3.obj
$(INTDIR)\nrooms.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c nrooms.c /Fo$(INTDIR)\nrooms.obj
$(INTDIR)\objcts.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c objcts.c /Fo$(INTDIR)\objcts.obj
$(INTDIR)\rooms.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c rooms.c /Fo$(INTDIR)\rooms.obj
$(INTDIR)\sobjs.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c sobjs.c /Fo$(INTDIR)\sobjs.obj
$(INTDIR)\sverbs.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c sverbs.c /Fo$(INTDIR)\sverbs.obj
$(INTDIR)\verbs.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c verbs.c /Fo$(INTDIR)\verbs.obj
$(INTDIR)\villns.obj: funcs.h vars.h
    $(CC) $(CFLAGS) -c villns.c /Fo$(INTDIR)\villns.obj

$(INTDIR)\wcio.obj: funcs.h vars.h wcio.h wcio.c
    $(CC) $(CFLAGS) -c -TP wcio.c /Fo$(INTDIR)\wcio.obj

!ELSEIF  "$(CFG)" == "wcZork - Win32 Debug"

!ENDIF

!IF "$(CFG)" == "wcZork - Win32 Release" || "$(CFG)" == "wcZork - Win32 Debug"

"$(INTDIR)\actors.obj" : actors.c "$(INTDIR)"
"$(INTDIR)\ballop.obj" : ballop.c "$(INTDIR)"
"$(INTDIR)\clockr.obj" : clockr.c "$(INTDIR)"
"$(INTDIR)\demons.obj" : demons.c "$(INTDIR)"
"$(INTDIR)\dgame.obj" : dgame.c "$(INTDIR)"
"$(INTDIR)\dinit.obj" : dinit.c "$(INTDIR)"
"$(INTDIR)\dmain.obj" : dmain.c "$(INTDIR)"
"$(INTDIR)\dso1.obj" : dso1.c "$(INTDIR)"
"$(INTDIR)\dso2.obj" : dso2.c "$(INTDIR)"
"$(INTDIR)\dso3.obj" : dso3.c "$(INTDIR)"
"$(INTDIR)\dso4.obj" : dso4.c "$(INTDIR)"
"$(INTDIR)\dso5.obj" : dso5.c "$(INTDIR)"
"$(INTDIR)\dso6.obj" : dso6.c "$(INTDIR)"
"$(INTDIR)\dso7.obj" : dso7.c "$(INTDIR)"
"$(INTDIR)\dsub.obj" : dsub.c "$(INTDIR)"
"$(INTDIR)\dverb1.obj" : dverb1.c "$(INTDIR)"
"$(INTDIR)\dverb2.obj" : dverb2.c "$(INTDIR)"
"$(INTDIR)\gdt.obj" : gdt.c "$(INTDIR)"
"$(INTDIR)\lightp.obj" : lightp.c "$(INTDIR)"
"$(INTDIR)\local.obj" : local.c "$(INTDIR)"
"$(INTDIR)\nobjs.obj" : nobjs.c "$(INTDIR)"
"$(INTDIR)\np.obj" : np.c "$(INTDIR)"
"$(INTDIR)\np1.obj" : np1.c "$(INTDIR)"
"$(INTDIR)\np2.obj" : np2.c "$(INTDIR)"
"$(INTDIR)\np3.obj" : np3.c "$(INTDIR)"
"$(INTDIR)\nrooms.obj" : nrooms.c "$(INTDIR)"
"$(INTDIR)\objcts.obj" : objcts.c "$(INTDIR)"
"$(INTDIR)\rooms.obj" : rooms.c "$(INTDIR)"
"$(INTDIR)\sobjs.obj" : sobjs.c "$(INTDIR)"
"$(INTDIR)\supp.obj" : supp.c "$(INTDIR)"
"$(INTDIR)\sverbs.obj" : sverbs.c "$(INTDIR)"
"$(INTDIR)\verbs.obj" : verbs.c "$(INTDIR)"
"$(INTDIR)\villns.obj" : villns.c "$(INTDIR)"
"$(INTDIR)\wcio.obj" : wcio.c wcio.h "$(INTDIR)"

!ENDIF


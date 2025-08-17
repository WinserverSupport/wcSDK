@echo off
    setlocal

    set src.path=\local\wc8
    set tar.path=\local\wc8\wcsdk\wcserver\cpp

    if exist $missing-libs.txt erase $missing-libs.txt

    goto :start

:start
    call :do_update commlib.lib
    call :do_update door32.lib
    call :do_update mimelib.lib
    goto :finish

    call :do_update msgthread.lib
    call :do_update sqlite3.lib
    call :do_update wccdll.lib
    call :do_update wccore.lib
    call :do_update wccorehlp.lib
    call :do_update wcdkim.lib
    call :do_update wcdkimapi.lib
    call :do_update wcDkimHelper.lib
    call :do_update wcdns.lib
    call :do_update wcDoor32.lib
    call :do_update wcfront.lib
    call :do_update wciphlpapi.lib
    call :do_update wciptrack.lib
    call :do_update wcmp3lib.lib
    call :do_update wcmsgdb.lib
    call :do_update wcodbc.lib
    call :do_update wcsmtpft.lib
    call :do_update wcSMtpStats.lib
    call :do_update wcspf.lib
    call :do_update wcsrv.lib
    call :do_update wcsrv2.lib
    call :do_update wcvb.lib
    call :do_update wcxml.lib
    call :do_update xmllib.lib
    call :do_update zlib.lib
    call :do_update zlibapi.lib
    goto :finish

:finish
    cecho "- DONE"
    goto :eof

:do_update
    cecho "* Updating %1"

    call :do_dir lib %1
    call :do_dir lib32 %1
    call :do_dir lib32xp %1
    call :do_dir lib32xpd %1
    call :do_dir lib64 %1
    call :do_dir lib64xp %1
    call :do_dir lib64xpd %1
    call :do_dir libd %1
    goto :eof


:do_dir
    cecho "- %1\%2"

    set src.file=%src.path%\%1\%2
    set tar.file=%tar.path%\%1\%2
    set tar.lib=%tar.path%\%1

    if not exist %src.file% (
       echo %src.file% >> $missing-libs.txt
       goto :eof
    )
    xcopy %src.file% %tar.lib% /d /y> nul

    goto :eof




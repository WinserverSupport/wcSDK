////////////////////////////////////////////////////////////////////////////
//
// This is a PASCAL sample which shows how to use the 32-bit door
// interface (DOOR32.DLL).
//
// Basically you just call DoorInitialize to start up, and DoorShutdown
// to clean up.  Writing to the port is done with DoorWrite, no
// translation of any kind is done, just raw output.  DoorRead will
// read characters from the input buffer.  It just returns with no
// characters read if there isn't anything to read (it does not block).
//
// The Wildcat version of DOOR32.DLL also hooks you up in the user's
// context in the Wildcat server, so you can call Wildcat server
// API functions.  The example here gets the user name.
//
////////////////////////////////////////////////////////////////////////////

{$APPTYPE CONSOLE}
{$H-,O+,A-}

program dortst32;
uses
   sysutils,
   windows,
   door32,
   wctype,
   wcserver;

procedure co(const ch : char);
  begin
    write(ch);
    DoorWrite(@ch,1);
  end;

procedure coln(s : string);
  begin
    s := s + #13#10;
    write(s);
    DoorWrite(@s[1],length(s));
  end;

var
    User       : Tuser;
    done       : boolean;
    Events     : array[0..2] of thandle;
    ch         : char;

begin

 if Not DoorInitialize() then
    begin
      writeln('ERROR: Could not initialize door ',GetLastError);
      readln;
      halt;
    end;

  try
    WildcatLoggedIn(User);
    coln(Format('Welcome to Doortest [%s] ',[User.Info.Name]));
    coln('Press a key or ESCAPE to quit: ');

    done := FALSE;
    while not done do
      begin
        Events[0] := DoorGetAvailableEventHandle;
        Events[1] := DoorGetOfflineEventHandle;
        case WaitForMultipleObjects(2, @Events, FALSE, INFINITE) of
         WAIT_OBJECT_0:
            begin
              while (DoorRead(@ch, 1) > 0) do begin
                 done := ch = #27;
                 if (not done) then co(ch);
              end;
            end;
         WAIT_OBJECT_0+1:
            begin
             done := TRUE;
            end;
        end;
      end;

  finally
    coln('Returning to bbs..');
    DoorShutdown();
  end;
end.

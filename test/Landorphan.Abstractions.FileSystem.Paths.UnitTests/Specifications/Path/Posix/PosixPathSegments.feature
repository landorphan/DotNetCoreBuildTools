@Check-In
Feature: Posix Path Segments
	In order to develop a reliable Windows Path parser 
	As a member of the Landorphan Team
	I want to to be able to convert incoming paths into a more managable form

Scenario Outline: Posix Segmenter generates the following segments
	Given I have the following path: <Path>
         # NOTE: the segmentor does not produce a normalized form.
	 When I segment the Posix path
	 Then segment '0' should be: <Segment 0>
     And segment '1' should be: <Segment 1>
     And segment '2' should be: <Segment 2>
     And segment '3' should be: <Segment 3>
     And segment '4' should be: <Segment 4>
Examples:
# NOTE: Due to Gherkin parsing rules, \ needs to be escaped.  In order to avoid that necissity and
# make the following examples easier to read (/) will be used in place of the (\) character
#
# Path Segment Type Shorthand:
# {0} = NullSegment, {E} = EmptySegment, {R} = RootSegment, {D} = DeviceSegment, {$} = VolumelessRootSegment
# {V} = VolumeRelativeSegment, {X} = RemoteSegment, {G} = Segment, {S} = SelfSegment, {P} = ParentSegment
| Path                              | Segment 0      | Segment 1    | Segment 2    | Segment 3    | Segment 4    | Segment 5    |
| (null)                            | {0} (null)     | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| (empty)                           | {E} (empty)    | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| C:/                               | {G} C:         | {E} (empty)  | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| C:/dir/file.txt                   | {G} C:         | {G} dir      | {G} file.txt | {0} (null)   | {0} (null)   | {0} (null)   |
| C:/dir/file.txt/                  | {G} C:         | {G} dir      | {G} file.txt | {E} (empty)  | {0} (null)   | {0} (null)   |
| C:/dir                            | {G} C:         | {G} dir      | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| C:/dir/                           | {G} C:         | {G} dir      | {E} (empty)  | {0} (null)   | {0} (null)   | {0} (null)   |
| C:/dir//file.txt                  | {G} C:         | {G} dir      | {E} (empty)  | {G} file.txt | {0} (null)   | {0} (null)   |
| C:./file.txt                      | {G} C:.        | {G} file.txt | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| C:./file.txt/                     | {G} C:.        | {G} file.txt | {E} (empty)  | {0} (null)   | {0} (null)   | {0} (null)   |
| C:file.txt                        | {G} C:file.txt | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| C:file.txt/                       | {G} C:file.txt | {E} (empty)  | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| C:dir                             | {G} C:dir      | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| C:dir/                            | {G} C:dir      | {E} (empty)  | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| C:dir/file.txt                    | {G} C:dir      | {G} file.txt | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| C:dir/file.txt/                   | {G} C:dir      | {G} file.txt | {E} (empty)  | {0} (null)   | {0} (null)   | {0} (null)   |
| //server/share                    | {X} server     | {G} share    | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| //server/share/                   | {X} server     | {G} share    | {E} (empty)  | {0} (null)   | {0} (null)   | {0} (null)   |
| //server/file.txt                 | {X} server     | {G} file.txt | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| //server/file.txt/                | {X} server     | {G} file.txt | {E} (empty)  | {0} (null)   | {0} (null)   | {0} (null)   |
| //server/share/dir/file.txt       | {X} server     | {G} share    | {G} dir      | {G} file.txt | {0} (null)   | {0} (null)   |
| //server/share/dir/file.txt/      | {X} server     | {G} share    | {G} dir      | {G} file.txt | {E} (empty)  | {0} (null)   |
| //?/C:/dir/file.txt               | {X} ?          | {G} C:       | {G} dir      | {G} file.txt | {0} (null)   | {0} (null)   |
| //?/C:/dir/file.txt/              | {X} ?          | {G} C:       | {G} dir      | {G} file.txt | {E} (empty)  | {0} (null)   |
| //?/UNC/server/share/dir/file.txt | {X} ?          | {G} UNC      | {G} server   | {G} share    | {G} dir      | {G} file.txt |
| //?/UNC/server//file.txt/         | {X} ?          | {G} UNC      | {G} server   | {E} (empty)  | {G} file.txt | {E} (empty)  |
| /dir/file.txt/                    | {R}            | {G} dir      | {G} file.txt | {E} (empty)  | {0} (null)   | {0} (null)   |
| .                                 | {S} .          | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| ./                                | {S} .          | {E} (empty)  | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| ./file.txt                        | {S} .          | {G} file.txt | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| ./file.txt/                       | {S} .          | {G} file.txt | {E} (empty)  | {0} (null)   | {0} (null)   | {0} (null)   |
| ./dir                             | {S} .          | {G} dir      | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| ./dir/                            | {S} .          | {G} dir      | {E} (empty)  | {0} (null)   | {0} (null)   | {0} (null)   |
| ./dir/file.txt                    | {S} .          | {G} dir      | {G} file.txt | {0} (null)   | {0} (null)   | {0} (null)   |
| ./dir/file.txt/                   | {S} .          | {G} dir      | {G} file.txt | {E} (empty)  | {0} (null)   | {0} (null)   |
| ..                                | {P} ..         | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| ../                               | {P} ..         | {E} (empty)  | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| ../dir/file.txt                   | {P} ..         | {G} dir      | {G} file.txt | {0} (null)   | {0} (null)   | {0} (null)   |
| ../dir/file.txt/                  | {P} ..         | {G} dir      | {G} file.txt | {E} (empty)  | {0} (null)   | {0} (null)   |
# Device paths should resolve to a device but the unnormalized segments will still be present				   
| CON                               | {G} CON        | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| C:/CON                            | {G} C:         | {G} CON      | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| ../CON                            | {P} ..         | {G} CON      | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| /dir/CON                          | {R}            | {G} dir      | {G} CON      | {0} (null)   | {0} (null)   | {0} (null)   |
# A Byproduct of the parser means the following will be accepted as a legitimate source                                   
| UNC:server                        | {X} server     | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| UNC:server/                       | {X} server     | {E} (empty)  | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| UNC:server/share                  | {X} server     | {G} share    | {0} (null)   | {0} (null)   | {0} (null)   | {0} (null)   |
| UNC:server/share/                 | {X} server     | {G} share    | {E} (empty)  | {0} (null)   | {0} (null)   | {0} (null)   |
| UNC:server/share/dir              | {X} server     | {G} share    | {G} dir      | {0} (null)   | {0} (null)   | {0} (null)   |
| UNC:server/share/dir/             | {X} server     | {G} share    | {G} dir      | {E} (empty)  | {0} (null)   | {0} (null)   |
																											   
@Check-In
Feature: PosixPaths
	In order to reliably interact with the file systems of multiple platforms
	As a developer
	I want to be able to parse paths on multiple platforms correctly

Scenario Outline: Posix Paths
	Given I have the following path: <Path>
	  And I'm running on the following Operating System: Linux
	 When I parse the path 
      And I evaluate the original form
	 Then I should receive a path object
	  And segment '0' should be: <Segment 0>
	  And segment '1' should be: <Segment 1>
	  And segment '2' should be: <Segment 2>
	  And segment '3' should be: <Segment 3>
	  And segment '4' should be: <Segment 4>
	  And segment '5' should be: <Segment 5>
	  And segment '6' should be: <Segment 6>
	  And the parse path should be anchored to <Anchor>
	  And the parse status should be <Status>
	  And the parse path's IsDiscouraged property should be <Is Discouraged>
	  And the segment length should be <Length>
	  And the PathType should be Posix
#	  And the psth's IsNoramlized property should be <Is Normalized> 
# NOTE: Due to Gherkin parsing rules, \ needs to be escaped.  In order to avoid that necissity and
# make the following examples easier to read (`) will be used in place of the (\) character
#
# NOTES:
# Per the spec, the following characters are illegal (anywere in the path)
# ILLEGAL CHARACTERS: 0x00
# 
# Per the spec, the following characters always represent a Path Separator regarless of location and can not be part of the path
# Foward Slash (/)
#
# Per the spec, the following characters are reserved and have special meaning: No such characters for Posix paths  
#
# Path Segment Type Shorthand:
# {0} = NullSegment, {E} = EmptySegment, {R} = RootSegment, {D} = DeviceSegment, {$} = VolumelessRootSegment
# {V} = VolumeRelativeSegment, {X} = RemoteSegment, {G} = Segment, {S} = SelfSegment, {P} = ParentSegment
Examples: 
| Name               | Path                        | Length | Segment 0  | Segment 1             | Segment 2    | Segment 3    | Segment 4  | Segment 5   | Segment 6  | Anchor   | Status  | Is Discouraged |
# a null string can be parsed but will produce a null path (which is an illegal path)												 														    
| Null               | (null)                      | 1      | {S} .      | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
# an empty string can be parsed but will produce an empty path (which is an illegal path)											 														   
| Empty              | (empty)                     | 1      | {S} .      | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
# Volume Absolute and Volume Relative have no meaning in Posix																		 														  
| Volume Absolute    | c:                          | 1      | {G} c:     | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| Volume Relative    | C:/./file.txt               | 3      | {G} C:     | {S} .                 | {G} file.txt | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| UNC                | //server/share/dir/file.txt | 4      | {X} server | {G} share             | {G} dir      | {G} file.txt | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long Volume Abs    | //?/C:/dir/file.txt         | 4      | {X} ?      | {G} C:                | {G} dir      | {G} file.txt | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Self Relative      | ./dir/file.txt              | 3      | {S} .      | {G} dir               | {G} file.txt | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| Parent Relative    | ../dir/file.txt             | 3      | {P} ..     | {G} dir               | {G} file.txt | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
# Empty segments will show up in the non-normalized for but will not be present in the normalized form								 														  
| Empty Abs Segment  | C:/dir//file.txt            | 4      | {G} C:     | {G} dir               | {E} (empty)  | {G} file.txt | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| Empty Rel Segment  | ./dir//file.txt             | 4      | {S} .      | {G} dir               | {E} (empty)  | {G} file.txt | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| Relative           | dir/file.txt                | 2      | {G} dir    | {G} file.txt          | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
# Normalizaiton level does not increase once it is below zero																		 														   
| Neg Normal 2       | ../../-1/0/1                | 5      | {P} ..     | {P} ..                | {G} -1       | {G} 0        | {G} 1      | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| Neg Normal 1       | ./../-1/0/1                 | 5      | {S} .      | {P} ..                | {G} -1       | {G} 0        | {G} 1      | {0} (null)  | {0} (null) | Relative | Legal   | false          |
## The following have absolutly no specail meaning in Posix paths																	 														   
| CON                | CON                         | 1      | {G} CON    | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| PRN                | PRN                         | 1      | {G} PRN    | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| AUX                | AUX                         | 1      | {G} AUX    | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| NUL                | NUL                         | 1      | {G} NUL    | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| COM1               | COM1                        | 1      | {G} COM1   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| COM2               | COM2                        | 1      | {G} COM2   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| COM3               | COM3                        | 1      | {G} COM3   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| COM4               | COM4                        | 1      | {G} COM4   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| COM5               | COM5                        | 1      | {G} COM5   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| COM6               | COM6                        | 1      | {G} COM6   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| COM7               | COM7                        | 1      | {G} COM7   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| COM8               | COM8                        | 1      | {G} COM8   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| COM9               | COM9                        | 1      | {G} COM9   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| LPT1               | LPT1                        | 1      | {G} LPT1   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| LPT2               | LPT2                        | 1      | {G} LPT2   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| LPT3               | LPT3                        | 1      | {G} LPT3   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| LPT4               | LPT4                        | 1      | {G} LPT4   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| LPT5               | LPT5                        | 1      | {G} LPT5   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| LPT6               | LPT6                        | 1      | {G} LPT6   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| LPT7               | LPT7                        | 1      | {G} LPT7   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| LPT8               | LPT8                        | 1      | {G} LPT8   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
| LPT9               | LPT9                        | 1      | {G} LPT9   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
## Long variants of the device paths are also have no special meaning																 														 
| Long CON           | //?/CON                     | 2      | {X} ?      | {G} CON               | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long PRN           | //?/PRN                     | 2      | {X} ?      | {G} PRN               | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long AUX           | //?/AUX                     | 2      | {X} ?      | {G} AUX               | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long NUL           | //?/NUL                     | 2      | {X} ?      | {G} NUL               | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long COM1          | //?/COM1                    | 2      | {X} ?      | {G} COM1              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long COM2          | //?/COM2                    | 2      | {X} ?      | {G} COM2              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long COM3          | //?/COM3                    | 2      | {X} ?      | {G} COM3              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long COM4          | //?/COM4                    | 2      | {X} ?      | {G} COM4              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long COM5          | //?/COM5                    | 2      | {X} ?      | {G} COM5              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long COM6          | //?/COM6                    | 2      | {X} ?      | {G} COM6              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long COM7          | //?/COM7                    | 2      | {X} ?      | {G} COM7              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long COM8          | //?/COM8                    | 2      | {X} ?      | {G} COM8              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long COM9          | //?/COM9                    | 2      | {X} ?      | {G} COM9              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long LPT1          | //?/LPT1                    | 2      | {X} ?      | {G} LPT1              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long LPT2          | //?/LPT2                    | 2      | {X} ?      | {G} LPT2              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long LPT3          | //?/LPT3                    | 2      | {X} ?      | {G} LPT3              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long LPT4          | //?/LPT4                    | 2      | {X} ?      | {G} LPT4              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long LPT5          | //?/LPT5                    | 2      | {X} ?      | {G} LPT5              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long LPT6          | //?/LPT6                    | 2      | {X} ?      | {G} LPT6              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long LPT7          | //?/LPT7                    | 2      | {X} ?      | {G} LPT7              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long LPT8          | //?/LPT8                    | 2      | {X} ?      | {G} LPT8              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
| Long LPT9          | //?/LPT9                    | 2      | {X} ?      | {G} LPT9              | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Absolute | Legal   | false          |
# Per previous tests, device path's have no special meaning in Posix																 														     
| Rel CON            | .././CON                    | 3      | {P} ..     | {S} .                 | {G} CON      | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
# Per previous tests, device path's have no special meaning in Posix																 														    
| Abs Con            | C:/CON                      | 2      | {G} C:     | {G} CON               | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
# Per previous tests, device path's have no special meaning in Posix																 														    
| Volume CON         | CON:                        | 1      | {G} CON:   | {0} (null)            | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
# Per previous tests, device path's have no special meaning in Posix (NOTE: This is NOT Discouraged on Posix) 						 														     
| Discuraged Rel NUL | ./NUL.txt                   | 2      | {S} .      | {G} NUL.txt           | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
# Nonprintable charachters are legal but Discuraged 																				 														    
| Illegal Rel Astr   | ./start-%03-end.txt         | 2      | {S} .      | {G} start-%03-end.txt | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | true           |
# Using an illegal character in a path is illegal																					 														   
| Illegal Rel Astr   | ./start-%00-end.txt         | 2      | {S} .      | {G} start-%00-end.txt | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Illegal | false          |
# Question mark is legal any place on Posix																							 														   
| Illegal Rel Ques   | ./foo?bar.txt               | 2      | {S} .      | {G} foo?bar.txt       | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
# Colon is legaln any place on Posix																								 														   
| Illegal Rel Colon  | ./foo:bar.txt               | 2      | {S} .      | {G} foo:bar.txt       | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | false          |
# Spaces at begining or end of a path is discurraged 																				 														    
| Space Beginning    | ./%20test.txt               | 2      | {S} .      | {G} %20test.txt       | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | true           |
| Space Ending       | ./test.txt%20               | 2      | {S} .      | {G} test.txt%20       | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | true           |
| Space Both         | ./%20t.txt%20               | 2      | {S} .      | {G} %20t.txt%20       | {0} (null)   | {0} (null)   | {0} (null) | {0} (null)  | {0} (null) | Relative | Legal   | true           |
| Root Pos Back      | /a/b/../c/../e              | 7      | {R}        | {G} a                 | {G} b        | {P} ..       | {G} c      | {P} ..      | {G} e      | Absolute | Legal   | false          |
| Root Neg Back      | /a/b/../../../e             | 7      | {R}        | {G} a                 | {G} b        | {P} ..       | {P} ..     | {P} ..      | {G} e      | Absolute | Legal   | false          |
| Root Neg Back 2    | /a/../../e/                 | 6      | {R}        | {G} a                 | {P} ..       | {P} ..       | {G} e      | {E} (empty) | {0} (null) | Absolute | Legal   | false          |

## NOTE: There are no pipe test cases here (because Gherkin uses that for the table, we will have to test those in scenarios and not ountlines)


# TODO: Add this back latter it's too long for current test system
# TODO: This can be added back now!
#| Long UNC           | //?/UNC/server/share/dir/file.txt | 4      | {X} server  | {G} share             | {G} dir      | {G} file.txt | Absolute | Legal       |

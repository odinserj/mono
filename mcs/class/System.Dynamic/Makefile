thisdir = class/System.Dynamic
SUBDIRS = 
include ../../build/rules.make

LIBRARY = System.Dynamic.dll

LIB_MCS_FLAGS = -unsafe -d:CODEPLEX_40 -r:System.Core.dll -r:System.dll -nowarn:414,169

# This is a .NET 4.0+ only assembly
VALID_PROFILE := $(filter 4, $(FRAMEWORK_VERSION_MAJOR))
ifndef VALID_PROFILE
LIBRARY_NAME = dummy-System.Dynamic.dll
NO_INSTALL = yes
NO_SIGN_ASSEMBLY = yes
NO_TEST = yes
NO_BUILD = yes
endif

include ../../build/library.make

#ifndef HOOK_H
#define HOOK_H

#include <Windows.h>
#include <inttypes.h>

class VHook {
private:
	static uintptr_t pTarget;
	static uintptr_t pDetour;

	static PVOID hHandle;
	static DWORD dwProtect;

public:
	static BOOL Hook(uintptr_t pTarget, uintptr_t pDetour);
	static BOOL Unhook();

private:
	static LONG WINAPI Handler(EXCEPTION_POINTERS *pExceptionInfo);

	static BOOL IsSamePage(const uint8_t* pFirstAddress, const uint8_t* pSecondAddress);
};

#endif // HOOK_H

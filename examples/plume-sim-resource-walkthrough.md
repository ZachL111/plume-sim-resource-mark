# Plume Sim Resource Mark Walkthrough

This note is the quickest way to read the extra review model in `plume-sim-resource-mark`.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 169 | ship |
| stress | state drift | 201 | ship |
| edge | review cost | 169 | ship |
| recovery | decision risk | 134 | watch |
| stale | input pressure | 226 | ship |

Start with `stale` and `recovery`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

The next useful expansion would be a malformed fixture around state drift and decision risk.

package utils

import "time"

func ConvertTimeUTC(timeStr string) time.Time {
	t, _ := time.Parse(time.DateOnly, timeStr)
	if t == (time.Time{}) {
		return t
	}

	systemLocation := time.Now().Location()

	return time.Date(t.Year(), t.Month(), t.Day(), 0, 0, 0, 0, systemLocation)
}

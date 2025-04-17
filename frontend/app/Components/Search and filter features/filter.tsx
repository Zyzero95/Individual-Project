'use client'

import { usePathname, useRouter, useSearchParams } from "next/navigation";
import { useState } from "react"
import styles from "./filter.module.css"
import { SlidersHorizontal } from "lucide-react";

export default function Filter() {
    const [selectOption, setSelectOption] = useState("default");

    const searchParams = useSearchParams();
    const pathName = usePathname();
    const { replace } = useRouter();

    const handleChange = (value: string) => {
        const params = new URLSearchParams(searchParams);
        setSelectOption(value);
        if(value !== "default") {
            params.set('filter', value.toLowerCase());
        }
        else {
            params.delete('filter');
        }
        replace(`${pathName}?${params.toString()}`);
    }

  return (
    <section className={styles.filterWrapper}>
        <select className={styles.filterSelect} aria-label="Filter Dropdown menu" id="filterSelect" onChange={(e) => {handleChange(e.target.value)}} defaultValue={selectOption}>
            <option value={"default"}>filter by...</option>
            <option value={"name"}>filter by name</option>
            <option value={"species"}>filter by species</option>
            <option value={"diet"}>filter by diet</option>
      </select>
      <SlidersHorizontal size={24}/>
    </section>
  )
}
